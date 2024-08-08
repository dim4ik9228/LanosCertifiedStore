using LanosCertifiedStore.Application.Shared.RequestRelated;

namespace LanosCertifiedStore.Application.Images.Commands.RemoveImageFromVehicleCommandRequestRelated;

public record RemoveImageFromVehicleCommandRequest(Guid VehicleId, Guid ImageId) : ICommandRequest;