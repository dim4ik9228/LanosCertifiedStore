﻿using Application.Shared.ResultRelated;
using MediatR;

namespace Application.CommandRequests.Models.CreateModel;

public sealed record CreateModelCommand(
    Guid BrandId,
    Guid TypeId,
    string Name,
    IEnumerable<Guid> AvailableEngineTypeIds,
    IEnumerable<Guid> AvailableTransmissionTypeIds,
    IEnumerable<Guid> AvailableDrivetrainTypeIds,
    IEnumerable<Guid> AvailableBodyTypeIds,
    int MinimalProductionYear,
    int? MaximumProductionYear = null) : IRequest<Result<Unit>>;