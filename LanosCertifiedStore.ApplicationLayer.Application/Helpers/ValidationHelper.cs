﻿using Domain.Contracts.Common;
using Domain.Contracts.RepositoryRelated;

namespace Application.Helpers;

internal sealed class ValidationHelper<TEntity>(IUnitOfWork unitOfWork)
    where TEntity : IEntity<Guid>
{
    internal async Task<bool> IsNameUniqueAsync(string name)
    {
        var brands = await unitOfWork.RetrieveRepository<TEntity>().GetAllEntitiesAsync();

        var propertyName = "Name";
        var nameProperty = typeof(TEntity).GetProperty(propertyName);

        if (nameProperty is null)
        {
            throw new InvalidOperationException(
                $"Type {typeof(TEntity).Name} does not have a property named {propertyName}.");
        }

        return brands.All(x =>
            !string.Equals((string?)nameProperty.GetValue(x), name, StringComparison.OrdinalIgnoreCase));
    }

    internal async Task<bool> ExistsById(Guid id)
    {
        return await unitOfWork.RetrieveRepository<TEntity>().GetEntityByIdAsync(id) is null;
    }
}