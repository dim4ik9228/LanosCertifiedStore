﻿using Application.Core;
using Application.Dtos.VehicleDtos;
using MediatR;

namespace Application.Queries.Vehicles.VehicleDetails;

public sealed record VehicleDetailsQuery(Guid Id) : IRequest<Result<VehicleDto>>;