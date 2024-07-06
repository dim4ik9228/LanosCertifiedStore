﻿using Application.Contracts.ServicesRelated;
using Application.Dtos.Common;
using Application.Shared.ResultRelated;
using MediatR;

namespace Application.QueryRequests.TypesRelated.VehicleBodyTypeRelated.CountVehicleBodyTypesQueryRelated;

internal sealed class CountBodyTypesQueryHandler(IVehicleBodyTypeService vehicleBodyTypeService)
    : IRequestHandler<CountVehicleBodyTypesQueryRequest, Result<ItemsCountDto>>
{
    public async Task<Result<ItemsCountDto>> Handle(CountVehicleBodyTypesQueryRequest request,
        CancellationToken cancellationToken)
    {
        var itemsCountDto = await vehicleBodyTypeService.GetVehicleBodyTypesCount(request, cancellationToken);

        return Result<ItemsCountDto>.Success(itemsCountDto);
    }
}