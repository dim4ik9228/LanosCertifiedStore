using FluentValidation.TestHelper;
using LanosCertifiedStore.Application.VehicleModels.Commands.CreateVehicleModelRelated;

namespace ApplicationUnitTests.VehicleModels.CreateVehicleModelCommand;

public sealed class CreateVehicleModelCommandRequestValidatorTests
{
    private readonly CreateVehicleModelCommandRequestValidator _validator;

    public CreateVehicleModelCommandRequestValidatorTests()
    {
        _validator = new CreateVehicleModelCommandRequestValidator();
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsEmpty()
    {
        // Arrange
        var model = CreateVehicleModelCommandTestExemplars.WithEmptyName();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsTooShort()
    {
        // Arrange
        var model = CreateVehicleModelCommandTestExemplars.WithTooShortName();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsTooLong()
    {
        // Arrange
        var model = CreateVehicleModelCommandTestExemplars.WithTooLongName();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfTransmissionTypesDoesNotExist()
    {
        // Arrange
        var model = CreateVehicleModelCommandTestExemplars.Regular();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableTransmissionTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfBodyTypesDoesNotExist()
    {
        // Arrange
        var model = CreateVehicleModelCommandTestExemplars.Regular();
        
        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableBodyTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfDrivetrainTypesDoesNotExist()
    {
        // Arrange
        var model = CreateVehicleModelCommandTestExemplars.Regular();
        
        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableDrivetrainTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfEngineTypesDoesNotExist()
    {
        // Arrange
        var model = CreateVehicleModelCommandTestExemplars.Regular();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableEngineTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_BrandDoesNotExist()
    {
        // Arrange
        var model = CreateVehicleModelCommandTestExemplars.Regular();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.BrandId);
    }

    [Fact]
    public async Task Should_HaveError_TypeDoesNotExist()
    {
        // Arrange
        var model = CreateVehicleModelCommandTestExemplars.Regular();
        
        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.TypeId);
    }

    [Theory]
    [InlineData(2000, 1998)]
    [InlineData(1899, 1998)]
    public async Task Should_HaveError_WhenMinimalProductionYearIsInvalid(
        int minimalProductionYear,
        int maximumProductionYear)
    {
        var model = CreateVehicleModelCommandTestExemplars.WithProductionYears(minimalProductionYear, maximumProductionYear);

        var result = await _validator.TestValidateAsync(model);

        result.ShouldHaveValidationErrorFor(m => m.MinimalProductionYear);
    }
}