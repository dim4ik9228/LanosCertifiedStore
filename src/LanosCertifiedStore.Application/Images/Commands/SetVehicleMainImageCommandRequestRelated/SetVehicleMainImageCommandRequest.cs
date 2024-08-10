using LanosCertifiedStore.Application.Shared.RequestRelated;

namespace LanosCertifiedStore.Application.Images.Commands.SetVehicleMainImageCommandRequestRelated;

public sealed record SetVehicleMainImageCommandRequest(Guid VehicleId, string ImageCloudId) : ICommandRequest;