﻿using Application.Commands.Vehicles.Common;
using Application.Shared;
using MediatR;

namespace Application.Commands.Vehicles.CreateVehicle;

public record CreateVehicleCommand(
    Guid ModelId,
    Guid ColorId,
    Guid BodyTypeId,
    Guid EngineTypeId,
    Guid TransmissionTypeId,
    Guid DrivetrainTypeId,
    Guid LocationRegionId,
    Guid LocationAreaId,
    Guid LocationTownId,
    string Description,
    double Displacement,
    decimal Price,
    int ProductionYear,
    int Mileage) : IActionVehicleCommandBase, IRequest<Result<Guid>>;