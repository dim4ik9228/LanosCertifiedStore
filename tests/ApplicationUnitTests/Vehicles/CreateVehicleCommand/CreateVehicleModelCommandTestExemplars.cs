using LanosCertifiedStore.Application.Vehicles.Commands.CreateVehicleCommandRequestRelated;

namespace ApplicationUnitTests.Vehicles.CreateVehicleCommand;

internal static class CreateVehicleCommandTestExemplars
{
    public static CreateVehicleCommandRequest Regular()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithEmptyDescription()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithShortDescription()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithLongDescription()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithInvalidPrice(decimal price)
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithInvalidDisplacement(double displacement)
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithInvalidMileage(int mileage)
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithEmptyBrandId()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.Empty,
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Mileage: 50000,
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithEmptyModelId()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.Empty,
            VehicleTypeId: Guid.NewGuid(),
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
            Mileage: 50000,
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithEmptyVehicleTypeId()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.Empty,
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
            Mileage: 50000,
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithEmptyBodyTypeId()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithEmptyEngineTypeId()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithEmptyTransmissionTypeId()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.Empty,
            DrivetrainTypeId: Guid.NewGuid(),
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: "This is a valid description with more than twenty characters",
            Displacement: 2.0,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: 50000,
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithEmptyDrivetrainTypeId()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
            BodyTypeId: Guid.NewGuid(),
            EngineTypeId: Guid.NewGuid(),
            TransmissionTypeId: Guid.NewGuid(),
            DrivetrainTypeId: Guid.Empty,
            ColorId: Guid.NewGuid(),
            LocationTownId: Guid.NewGuid(),
            Description: "This is a valid description with more than twenty characters",
            Displacement: 2.0,
            Price: 15000.00m,
            ProductionYear: 2020,
            Mileage: 50000,
            Vincode: "1HGCM82633A123456"
        );
    }

    public static CreateVehicleCommandRequest WithEmptyVincode()
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Mileage: 50000,
            Vincode: string.Empty
        );
    }

    public static CreateVehicleCommandRequest WithInvalidVincode(string vincode)
    {
        return new CreateVehicleCommandRequest(
            BrandId: Guid.NewGuid(),
            ModelId: Guid.NewGuid(),
            VehicleTypeId: Guid.NewGuid(),
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
            Mileage: 50000,
            Vincode: vincode
        );
    }
}