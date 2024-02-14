﻿using Application.Core;
using Application.Dtos.VehicleDtos;
using Application.RequestParams;
using AutoMapper;
using Domain.Contracts.RepositoryRelated;
using Domain.Entities.VehicleRelated.Classes;
using MediatR;

namespace Application.Queries.Vehicles.ListVehicles;

internal sealed class ListVehiclesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
    : IRequestHandler<ListVehiclesQuery, Result<PaginationResult<VehicleDto>>>
{
    public async Task<Result<PaginationResult<VehicleDto>>> Handle(ListVehiclesQuery request,
        CancellationToken cancellationToken)
    {
        var vehicles = await unitOfWork.RetrieveRepository<Vehicle>().GetAllEntitiesAsync(request.RequestParameters);

        var mappedVehicles = mapper.Map<IReadOnlyList<Vehicle>, IReadOnlyList<VehicleDto>>(vehicles);

        var returnedResult = new PaginationResult<VehicleDto>(
            mappedVehicles, request.RequestParameters.PageIndex, mappedVehicles.Count);

        return Result<PaginationResult<VehicleDto>>.Success(returnedResult);
    }
}