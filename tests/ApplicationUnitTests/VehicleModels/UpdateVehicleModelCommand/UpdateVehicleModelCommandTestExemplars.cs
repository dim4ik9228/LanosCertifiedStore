using LanosCertifiedStore.Application.VehicleModels.Commands.UpdateVehicleModelRelated;

namespace ApplicationUnitTests.VehicleModels.UpdateVehicleModelCommand;

internal static class UpdateVehicleModelCommandTestExemplars
{
    public static UpdateVehicleModelCommandRequest Regular()
    {
        return new UpdateVehicleModelCommandRequest(
            Guid.Empty,
            2004,
            [],
            [],
            [],
            []
        );
    }
}