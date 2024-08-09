using LanosCertifiedStore.Application.Shared.ResultRelated;
using LanosCertifiedStore.Application.Vehicles;
using LanosCertifiedStore.Application.Vehicles.Queries.SingleVehicleQueryRequestRelated;
using MediatR;

namespace LanosCertifiedStore.Application.Images.Commands.RemoveImageFromVehicleCommandRequestRelated;

internal sealed class RemoveImageFromVehicleCommandRequestHandler(
    IImageService imageService,
    IVehicleService vehicleService) : IRequestHandler<RemoveImageFromVehicleCommandRequest, Result>
{
    public async Task<Result> Handle(RemoveImageFromVehicleCommandRequest request, CancellationToken cancellationToken)
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
            return Result.Create(ImageErrors.DeletingMainImage);
        }

        var isSuccess = await imageService.TryDeletePhotoAsync(request.ImageCloudId);

        if (!isSuccess)
        {
            return Result.Create(ImageErrors.UnsuccessfulRemoval);
        }

        await vehicleService.RemoveImageFromVehicle(request.VehicleId, request.ImageCloudId, cancellationToken);
        return Result.Create(Error.None);
    }
}