using FluentValidation.TestHelper;
using LanosCertifiedStore.Application.Vehicles.Commands.UpdateVehicleCommandRequestRelated;

namespace ApplicationUnitTests.Vehicles.UpdateVehicleCommand;

public sealed class UpdateVehicleCommandRequestValidatorTests
{
    private readonly UpdateVehicleCommandRequestValidator _validator;

    public UpdateVehicleCommandRequestValidatorTests()
    {
        _validator = new UpdateVehicleCommandRequestValidator();
    }

    // Description Tests
    [Fact]
    public async Task Should_HaveError_WhenDescriptionIsEmpty()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.WithEmptyDescription();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Description);
    }

    [Fact]
    public async Task Should_HaveError_WhenDescriptionIsTooShort()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.WithShortDescription();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Description);
    }

    [Fact]
    public async Task Should_HaveError_WhenDescriptionIsTooLong()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.WithLongDescription();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Description);
    }

    // Numeric Value Tests
    [Fact]
    public async Task Should_HaveError_WhenPriceIsInvalid()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.WithInvalidPrice(-1);

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Price);
    }

    [Fact]
    public async Task Should_HaveError_WhenDisplacementIsInvalid()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.WithInvalidDisplacement(0);

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Displacement);
    }

    [Fact]
    public async Task Should_HaveError_WhenMileageIsInvalid()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.WithInvalidMileage(-1);

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Mileage);
    }

    // Type Validation Tests
    [Fact]
    public async Task Should_HaveError_WhenBodyTypeIdIsEmpty()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.WithEmptyBodyTypeId();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.BodyTypeId);
    }

    [Fact]
    public async Task Should_HaveError_WhenEngineTypeIdIsEmpty()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.WithEmptyEngineTypeId();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.EngineTypeId);
    }

    // Happy Path Test
    [Fact]
    public async Task Should_NotHaveError_WhenRequestIsValid()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.Regular();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldNotHaveAnyValidationErrors();
    }

    [Fact]
    public async Task Should_HaveError_WhenColorIdIsEmpty()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.Regular() with { ColorId = Guid.Empty };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ColorId);
    }

    [Fact]
    public async Task Should_HaveError_WhenTransmissionTypeIdIsEmpty()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.Regular() with { TransmissionTypeId = Guid.Empty };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.TransmissionTypeId);
    }

    [Fact]
    public async Task Should_HaveError_WhenDrivetrainTypeIdIsEmpty()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.Regular() with { DrivetrainTypeId = Guid.Empty };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.DrivetrainTypeId);
    }

    [Fact]
    public async Task Should_HaveError_WhenLocationTownIdIsEmpty()
    {
        // Arrange
        var request = UpdateVehicleCommandTestExemplars.Regular() with { LocationTownId = Guid.Empty };

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.LocationTownId);
    }
}