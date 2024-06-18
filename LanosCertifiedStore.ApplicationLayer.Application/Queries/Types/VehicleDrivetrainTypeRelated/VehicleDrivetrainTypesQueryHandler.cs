﻿using Application.Contracts.RepositoryRelated.Common;
using Application.Core.Results;
using Application.Dtos.TypeDtos;
using Application.Queries.Common.QueryRelated;
using Application.Shared;
using AutoMapper;
using Domain.Models.VehicleRelated.Classes.TypeRelated;
using MediatR;

namespace Application.Queries.Types.VehicleDrivetrainTypeRelated;

// TODO
// internal sealed class VehicleDrivetrainTypesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) :
//     ListQueryHandlerBase<VehicleDrivetrainType,
//         IFilteringRequestParameters<VehicleDrivetrainType>,
//         VehicleDrivetrainTypeDto>(unitOfWork, mapper),
//     IRequestHandler<VehicleDrivetrainTypesQuery, Result<PaginationResult<VehicleDrivetrainTypeDto>>>
// {
//     public Task<Result<PaginationResult<VehicleDrivetrainTypeDto>>> Handle(VehicleDrivetrainTypesQuery request,
//         CancellationToken cancellationToken) =>
//         base.Handle(request, cancellationToken);
// }