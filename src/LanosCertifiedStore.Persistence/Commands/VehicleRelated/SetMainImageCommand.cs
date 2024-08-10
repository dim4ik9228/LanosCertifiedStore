using LanosCertifiedStore.Domain.Entities.VehicleRelated;
using LanosCertifiedStore.Persistence.Contexts.ApplicationDatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace LanosCertifiedStore.Persistence.Commands.VehicleRelated;

public sealed class SetMainImageCommand(ApplicationDatabaseContext context)
{
    public async Task Execute(Guid vehicleId, string imageId, CancellationToken cancellationToken = default)
    {
        var images = await context
            .Set<VehicleImage>()
            .Where(i => i.VehicleId == vehicleId)
            .Where(i => i.IsMainImage || i.CloudImageId == imageId)
            .OrderByDescending(i => i.IsMainImage)
            .ToArrayAsync(cancellationToken);

        if (images.Length == 2)
        {
            images[0].IsMainImage = false;
            images[1].IsMainImage = true;
            return;
        }
        
        throw new InvalidOperationException($"Expected exactly 2 images, but found {images.Length}. Operation cannot be completed.");
    }
}