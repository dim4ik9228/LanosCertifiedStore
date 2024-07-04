﻿using Application.Contracts.RepositoryRelated.Common;
using Application.Contracts.RequestRelated.QueryRelated;
using Application.Core.Results;
using Application.Dtos.ColorDtos;
using Domain.Entities.VehicleRelated;

namespace Application.QueryRequests.Colors.CollectionVehicleColorsQueryRequestRelated;

public sealed record CollectionVehicleColorsQueryRequest(
    IFilteringRequestParameters<VehicleColor> FilteringParameters) :
    ICollectionQueryRequest<VehicleColor, PaginationResult<VehicleColorDto>, VehicleColorDto>;