using LanosCertifiedStore.Application.Shared.ResultRelated;
using LanosCertifiedStore.Application.Vehicles;
using MediatR;

namespace LanosCertifiedStore.Application.Images.Commands.RemoveImageFromVehicleCommandRequestRelated;

internal sealed class RemoveImageFromVehicleCommandRequestHandler(
    IImageService imageService,
    IVehicleService vehicleService) : IRequestHandler<RemoveImageFromVehicleCommandRequest, Result>
{
    public async Task<Result> Handle(RemoveImageFromVehicleCommandRequest request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}