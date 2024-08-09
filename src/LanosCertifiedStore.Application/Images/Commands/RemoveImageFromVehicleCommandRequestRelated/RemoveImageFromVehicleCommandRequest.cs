﻿using LanosCertifiedStore.Application.Shared.RequestRelated;

namespace LanosCertifiedStore.Application.Images.Commands.RemoveImageFromVehicleCommandRequestRelated;

public record RemoveImageFromVehicleCommandRequest(Guid VehicleId, string ImageCloudId) : ICommandRequest;