using FluentValidation.TestHelper;
using LanosCertifiedStore.Application.Vehicles.Commands.CreateVehicleCommandRequestRelated;

namespace ApplicationUnitTests.Vehicles.CreateVehicleCommand;

public sealed class CreateVehicleCommandRequestValidatorTests
{
    private readonly CreateVehicleCommandRequestValidator _validator;

    public CreateVehicleCommandRequestValidatorTests()
    {
        _validator = new CreateVehicleCommandRequestValidator();
    }

    // Description Tests
    [Fact]
    public async Task Should_HaveError_WhenDescriptionIsEmpty()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithEmptyDescription();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Description);
    }

    [Fact]
    public async Task Should_HaveError_WhenDescriptionIsTooShort()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithShortDescription();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Description);
    }

    [Fact]
    public async Task Should_HaveError_WhenDescriptionIsTooLong()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithLongDescription();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Description);
    }

    [Fact]
    public async Task Should_HaveError_WhenPriceIsInvalid()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithInvalidPrice(-1);

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Price);
    }

    [Fact]
    public async Task Should_HaveError_WhenDisplacementIsInvalid()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithInvalidDisplacement(0);

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Displacement);
    }

    [Fact]
    public async Task Should_HaveError_WhenMileageIsInvalid()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithInvalidMileage(-1);

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Mileage);
    }

    [Fact]
    public async Task Should_HaveError_WhenModelIdIsEmpty()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithEmptyModelId();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.ModelId);
    }

    [Fact]
    public async Task Should_HaveError_WhenBrandIdIsEmpty()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithEmptyBrandId();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.BrandId);
    }

    [Fact]
    public async Task Should_HaveError_WhenVincodeIsEmpty()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithEmptyVincode();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Vincode);
    }

    [Fact]
    public async Task Should_HaveError_WhenVincodeHasInvalidLength()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithInvalidVincode(new string(' ', 10));

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Vincode);
    }

    [Fact]
    public async Task Should_HaveError_WhenBodyTypeIdIsEmpty()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithEmptyBodyTypeId();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.BodyTypeId);
    }

    [Fact]
    public async Task Should_HaveError_WhenEngineTypeIdIsEmpty()
    {
        // Arrange
        var request = CreateVehicleCommandTestExemplars.WithEmptyEngineTypeId();

        // Act
        var result = await _validator.TestValidateAsync(request);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.EngineTypeId);
    }
}