using LanosCertifiedStore.Application.VehicleModels.Commands.CreateVehicleModelRelated;

namespace ApplicationUnitTests.VehicleModels.CreateVehicleModelCommand;

internal static class CreateVehicleModelCommandTestExemplars
{
    public static CreateVehicleModelCommandRequest Regular()
    {
        return new CreateVehicleModelCommandRequest(
            "test model",
            Guid.Empty,
            Guid.Empty,
            2004,
            2024,
            [],
            [],
            [],
            []
        );
    }

    public static CreateVehicleModelCommandRequest WithEmptyName()
    {
        return Regular() with { Name = string.Empty };
    }


    public static CreateVehicleModelCommandRequest WithTooShortName()
    {
        return Regular() with { Name = "A" };
    }


    public static CreateVehicleModelCommandRequest WithTooLongName()
    {
        return Regular() with { Name = new string('A', 65) };
    }

    public static CreateVehicleModelCommandRequest WithProductionYears(
        int minimalProductionYear,
        int maximumProductionYear)
    {
        return Regular() with
        {
            MinimalProductionYear = minimalProductionYear,
            MaximumProductionYear = maximumProductionYear
        };
    }
}