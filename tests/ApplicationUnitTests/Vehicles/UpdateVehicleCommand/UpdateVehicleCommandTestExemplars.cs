using LanosCertifiedStore.Application.Vehicles.Commands.UpdateVehicleCommandRequestRelated;

namespace ApplicationUnitTests.Vehicles.UpdateVehicleCommand;

internal static class UpdateVehicleCommandTestExemplars
{
    public static UpdateVehicleCommandRequest Regular()
    {
        return new UpdateVehicleCommandRequest(
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: "This is a valid description with more than twenty characters for testing",
            Displacement: 2.0,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: 50000,
            Id: Guid.NewGuid()
        );
    }

    public static UpdateVehicleCommandRequest WithEmptyDescription()
    {
        return new UpdateVehicleCommandRequest(
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: string.Empty,
            Displacement: 2.0,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: 50000,
            Id: Guid.NewGuid()
        );
    }

    public static UpdateVehicleCommandRequest WithShortDescription()
    {
        return new UpdateVehicleCommandRequest(
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: "Too short",
            Displacement: 2.0,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: 50000,
            Id: Guid.NewGuid()
        );
    }

    public static UpdateVehicleCommandRequest WithLongDescription()
    {
        return new UpdateVehicleCommandRequest(
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: new string('A', 3001),
            Displacement: 2.0,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: 50000,
            Id: Guid.NewGuid()
        );
    }

    public static UpdateVehicleCommandRequest WithInvalidPrice(decimal price)
    {
        return new UpdateVehicleCommandRequest(
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: "This is a valid description with more than twenty characters",
            Displacement: 2.0,
            Price: price,
            ProductionYear: 2020,
            Mileage: 50000,
            Id: Guid.NewGuid()
        );
    }

    public static UpdateVehicleCommandRequest WithInvalidDisplacement(double displacement)
    {
        return new UpdateVehicleCommandRequest(
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: "This is a valid description with more than twenty characters",
            Displacement: displacement,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: 50000,
            Id: Guid.NewGuid()
        );
    }

    public static UpdateVehicleCommandRequest WithInvalidMileage(int mileage)
    {
        return new UpdateVehicleCommandRequest(
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: "This is a valid description with more than twenty characters",
            Displacement: 2.0,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: mileage,
            Id: Guid.NewGuid()
        );
    }

    public static UpdateVehicleCommandRequest WithEmptyBodyTypeId()
    {
        return new UpdateVehicleCommandRequest(
            BodyTypeId: Guid.Empty,
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: "This is a valid description with more than twenty characters",
            Displacement: 2.0,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: 50000,
            Id: Guid.NewGuid()
        );
    }

    public static UpdateVehicleCommandRequest WithEmptyEngineTypeId()
    {
        return new UpdateVehicleCommandRequest(
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.Empty,
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: "This is a valid description with more than twenty characters",
            Displacement: 2.0,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: 50000,
            Id: Guid.NewGuid()
        );
    }
}