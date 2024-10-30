using LanosCertifiedStore.Application.Vehicles.Commands.DeleteVehicleCommandRequestRelated;

namespace ApplicationUnitTests.Vehicles.DeleteVehicleCommand;

internal static class DeleteVehicleCommandTestExemplars
{
    public static DeleteVehicleCommandRequest Regular()
    {
        return new DeleteVehicleCommandRequest(
            Id: Guid.NewGuid()
        );
    }
}