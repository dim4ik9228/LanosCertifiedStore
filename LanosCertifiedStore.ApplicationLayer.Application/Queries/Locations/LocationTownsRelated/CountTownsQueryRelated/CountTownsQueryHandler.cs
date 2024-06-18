﻿using Application.Contracts.RepositoryRelated.Common;
using Application.Dtos.Common;
using Application.Queries.Common.CountItemsQueryRelated;
using Application.Shared;
using Domain.Models.VehicleRelated.Classes.LocationRelated;
using MediatR;

namespace Application.Queries.Locations.LocationTownsRelated.CountTownsQueryRelated;

// TODO
// internal sealed class CountTownsQueryHandler(IUnitOfWork unitOfWork) : 
//     CountItemsQueryHandlerBase<VehicleLocationTown>(unitOfWork),
//     IRequestHandler<CountTownsQuery, Result<ItemsCountDto>>
// {
//     public Task<Result<ItemsCountDto>> Handle(
//         CountTownsQuery request, CancellationToken cancellationToken) =>
//         base.Handle(request, cancellationToken);
// }