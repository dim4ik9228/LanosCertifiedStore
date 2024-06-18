﻿using Application.Contracts.RepositoryRelated.Common;
using Application.Dtos.Common;
using Application.Queries.Common.CountItemsQueryRelated;
using Application.Shared;
using Domain.Models.VehicleRelated.Classes.TypeRelated;
using MediatR;

namespace Application.Queries.Types.VehicleBodyTypeRelated.CountBodyTypesQueryRelated;

// TODO
// internal sealed class CountBodyTypesQueryHandler(IUnitOfWork unitOfWork) : 
//     CountItemsQueryHandlerBase<VehicleBodyType>(unitOfWork),
//     IRequestHandler<CountBodyTypesQuery, Result<ItemsCountDto>>
// {
//     public Task<Result<ItemsCountDto>> Handle(
//         CountBodyTypesQuery request, CancellationToken cancellationToken) =>
//         base.Handle(request, cancellationToken);
// }