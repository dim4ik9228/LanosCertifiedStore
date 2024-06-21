﻿using System.Linq.Expressions;
using Application.Contracts.RepositoryRelated.Common;
using Domain.Contracts.Common;
using LinqKit;
using Persistence.Queries.Common.Contracts;

namespace Persistence.Queries.Common.Classes.QueryRelated;

internal abstract class QueryFilteringCriteriaSelectorBase<TModel, TEntity> : 
    IQueryFilteringCriteriaSelector<TModel, TEntity> 
    where TModel : class, IIdentifiable<Guid> 
    where TEntity : class, IIdentifiable<Guid>
{
    private Expression<Func<TEntity, bool>> _filteringCriteriaExpression = 
        PredicateBuilder.New<TEntity>(true);

    public Expression<Func<TEntity, bool>> GetCriteria(
        IFilteringRequestParameters<TModel>? filteringRequestParameters = null)
    {
        var aspects = GetAspectMappings(filteringRequestParameters!);

        TryApplyCriteriaAspects(aspects);

        return _filteringCriteriaExpression;
    }

    private void TryApplyCriteriaAspects(
        IReadOnlyCollection<(bool IsValid, Expression<Func<TEntity, bool>> Expression)> aspects)
    {
        foreach (var aspect in aspects)
        {
            if (aspect.IsValid)
                AddFilteringCriteriaAspect(aspect.Expression);
        }
    }

    private void AddFilteringCriteriaAspect(Expression<Func<TEntity, bool>> aspectExpression)
    {
        _filteringCriteriaExpression = _filteringCriteriaExpression.And(aspectExpression);
    }

    private protected abstract IReadOnlyCollection<(bool IsValid, Expression<Func<TEntity, bool>> Expression)> 
        GetAspectMappings(IFilteringRequestParameters<TModel> filteringRequestParameters);
}