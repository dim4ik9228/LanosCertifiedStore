using LanosCertifiedStore.Domain.Entities.VehicleRelated;
using LanosCertifiedStore.Persistence.Contexts.ApplicationDatabaseContext;
using Microsoft.EntityFrameworkCore;

namespace LanosCertifiedStore.Persistence.Commands.VehicleRelated;

public sealed class RemoveImageFromVehicleCommand(ApplicationDatabaseContext context)
{
    public async Task Execute(Guid vehicleId, string imageId, CancellationToken cancellationToken = default)
    {
        var result = await context
            .Set<VehicleImage>()
            .Where(i => i.VehicleId == vehicleId && i.CloudImageId == imageId)
            .ExecuteDeleteAsync();

        if (result == 0)
        {
            throw new KeyNotFoundException();
        }
    }
}