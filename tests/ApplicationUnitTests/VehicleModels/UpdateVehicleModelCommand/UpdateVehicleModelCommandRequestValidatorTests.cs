using FluentValidation.TestHelper;
using LanosCertifiedStore.Application.VehicleModels.Commands.UpdateVehicleModelRelated;

namespace ApplicationUnitTests.VehicleModels.UpdateVehicleModelCommand;

public sealed class UpdateVehicleModelCommandRequestValidatorTests
{
    private readonly UpdateVehicleModelCommandRequestValidator _validator;

    public UpdateVehicleModelCommandRequestValidatorTests()
    {
        _validator = new UpdateVehicleModelCommandRequestValidator();
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfTransmissionTypesDoesNotExist()
    {
        // Arrange
        var model = UpdateVehicleModelCommandTestExemplars.Regular();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableTransmissionTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfBodyTypesDoesNotExist()
    {
        // Arrange
        var model = UpdateVehicleModelCommandTestExemplars.Regular();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableBodyTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfDrivetrainTypesDoesNotExist()
    {
        // Arrange
        var model = UpdateVehicleModelCommandTestExemplars.Regular();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableDrivetrainTypesIds);
    }

    [Fact]
    public async Task Should_HaveError_WhenAnyOfEngineTypesDoesNotExist()
    {
        // Arrange
        var model = UpdateVehicleModelCommandTestExemplars.Regular();

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.AvailableEngineTypesIds);
    }
}