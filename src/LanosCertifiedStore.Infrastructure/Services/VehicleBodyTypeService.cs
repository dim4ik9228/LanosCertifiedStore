﻿using Application.Contracts.ServicesRelated;
using Application.Dtos.TypeDtos;
using Application.QueryRequests.TypesRelated.VehicleBodyTypeRelated.CollectionVehicleBodyTypesQueryRelated;
using Persistence.Queries.TypeRelated.VehicleBodyTypeRelated.QueryRelated;

namespace LanosCertifiedStore.InfrastructureLayer.Services.Services;

internal sealed class VehicleBodyTypeService(
    CollectionVehicleBodyTypesQuery collectionVehicleBodyTypesQuery) : IVehicleBodyTypeService
{
    public async Task<IReadOnlyCollection<VehicleBodyTypeDto>> GetVehicleBodyTypeCollection(
        CollectionVehicleBodyTypesQueryRequest queryRequest,
        CancellationToken cancellationToken)
    {
        return await collectionVehicleBodyTypesQuery.Execute(queryRequest, cancellationToken);
    }
}