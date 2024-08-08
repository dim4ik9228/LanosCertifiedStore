using LanosCertifiedStore.Application.Shared.RequestRelated;
using Microsoft.AspNetCore.Http;

namespace LanosCertifiedStore.Application.Images.Commands.AddImageToVehicleCommandRequestRelated;

public sealed record AddImagesToVehicleCommandRequest(
    Guid VehicleId,
    List<IFormFile> Images) : ICommandRequest;