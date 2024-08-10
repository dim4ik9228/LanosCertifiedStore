using LanosCertifiedStore.Application.Shared.ResultRelated;
using LanosCertifiedStore.Application.Vehicles;
using LanosCertifiedStore.Application.Vehicles.Queries.SingleVehicleQueryRequestRelated;
using MediatR;

namespace LanosCertifiedStore.Application.Images.Commands.SetVehicleMainImageCommandRequestRelated;

internal sealed class SetVehicleMainImageCommandHandler(
    IVehicleService vehicleService) : IRequestHandler<SetVehicleMainImageCommandRequest, Result>
{
    public async Task<Result> Handle(SetVehicleMainImageCommandRequest request, CancellationToken cancellationToken)
    {
        var vehicle = await vehicleService.GetVehicle(
            new SingleVehicleQueryRequest(request.VehicleId),
            cancellationToken);

        if (vehicle is null)
        {
            return Result.Create(Error.NotFound(request.VehicleId));
        }

        if (vehicle.Images is null || !vehicle.Images.Any())
        {
            return Result.Create(ImageErrors.NoImages);
        }

        var image = vehicle.Images.FirstOrDefault(i => i.CloudImageId == request.ImageCloudId);

        if (image is null)
        {
            return Result.Create(ImageErrors.NotFound(request.ImageCloudId));
        }

        if (image.IsMainImage)
        {
            return Result.Create(ImageErrors.AlreadyMainImage);
        }

        await vehicleService.SetMainImage(request.VehicleId, request.ImageCloudId, cancellationToken);

        return Result.Create(Error.None);
    }
}