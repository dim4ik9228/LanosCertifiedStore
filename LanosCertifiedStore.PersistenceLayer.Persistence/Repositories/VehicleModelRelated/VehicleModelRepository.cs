﻿using Application.RequestParams;
using AutoMapper;
using Domain.Contracts.RepositoryRelated;
using Domain.Entities.VehicleRelated.Classes;
using Domain.Enums.RequestParametersRelated;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts.ApplicationDatabaseContext;
using Persistence.DataModels.VehicleRelated;
using Persistence.QueryEvaluation;
using Persistence.Repositories.Common.Classes;
using Persistence.Repositories.VehicleModelRelated.QueryEvaluationRelated;
using Persistence.Repositories.VehicleModelRelated.QueryEvaluationRelated.Common.Classes;

namespace Persistence.Repositories.VehicleModelRelated;

internal class VehicleModelRepository(IMapper mapper, ApplicationDatabaseContext dbContext)
    : GenericRepository<VehicleModelSelectionProfile, VehicleModel, VehicleModelDataModel>(mapper, dbContext)
{
    public override async Task<IReadOnlyList<VehicleModel>> GetAllEntitiesAsync(
        IFilteringRequestParameters<VehicleModel>? filteringRequestParameters = null!)
    {
        var vehicleModelsQuery = GetRelevantQueryable(filteringRequestParameters);

        var vehicleModels = await vehicleModelsQuery.AsNoTracking().ToListAsync();
        
        return Mapper.Map<IReadOnlyList<VehicleModelDataModel>, IReadOnlyList<VehicleModel>>(vehicleModels);
    }

    public override async Task<VehicleModel?> GetEntityByIdAsync(Guid id)
    {
        var vehicleModelQuery = QueryEvaluator.GetSingleEntityQueryable(
            id, Context.Set<VehicleModelDataModel>(), new VehicleModelFilteringRequestParameters
            {
                SelectionProfile = VehicleModelSelectionProfile.Single
            });

        var vehicleModel = await vehicleModelQuery.AsNoTracking().SingleOrDefaultAsync();
        
        return vehicleModel is not null 
            ? Mapper.Map<VehicleModelDataModel, VehicleModel>(vehicleModel) 
            : null;
    }

    public override Task<int> CountAsync(
        IFilteringRequestParameters<VehicleModel>? filteringRequestParameters = null)
    {
        var countedQueryable = QueryEvaluator.GetRelevantCountQueryable(
            Context.Set<VehicleModelDataModel>(),filteringRequestParameters);

        return countedQueryable.CountAsync();
    }

    private protected override IQueryable<VehicleModelDataModel> GetRelevantQueryable(
        IFilteringRequestParameters<VehicleModel>? filteringRequestParameters) =>
        QueryEvaluator.GetAllEntitiesQueryable(
            Context.Set<VehicleModelDataModel>(),filteringRequestParameters);

    private protected override BaseQueryEvaluator<VehicleModelSelectionProfile, VehicleModel, VehicleModelDataModel> 
        GetQueryEvaluator() =>
        new VehicleModelQueryEvaluator(new VehicleModelSelectionProfiles(), new VehicleModelFilteringCriteria());
}