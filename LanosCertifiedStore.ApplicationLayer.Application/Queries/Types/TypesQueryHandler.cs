﻿using Application.Core.Results;
using Application.Dtos.TypeDtos;
using Application.Queries.Common.QueryRelated;
using Application.RequestParams;
using AutoMapper;
using Domain.Contracts.RepositoryRelated;
using Domain.Entities.VehicleRelated.Classes;
using Domain.Shared;
using MediatR;

namespace Application.Queries.Types;

internal sealed class TypesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper) :
    ListQueryHandlerBase<VehicleType, VehicleTypeFilteringRequestParameters, TypeDto>(unitOfWork, mapper),
    IRequestHandler<TypesQuery, Result<PaginationResult<TypeDto>>>
{
    public Task<Result<PaginationResult<TypeDto>>> Handle(TypesQuery request,
        CancellationToken cancellationToken) =>
        base.Handle(request, cancellationToken);
}