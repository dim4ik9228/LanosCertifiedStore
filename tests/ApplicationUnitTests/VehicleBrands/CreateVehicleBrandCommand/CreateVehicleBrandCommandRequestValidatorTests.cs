using FluentValidation.TestHelper;
using LanosCertifiedStore.Application.VehicleBrands.Commands.CreateVehicleBrandRelated;

namespace ApplicationUnitTests.VehicleBrands.CreateVehicleBrandCommand;

public sealed class CreateVehicleBrandCommandRequestValidatorTests
{
    private readonly CreateVehicleBrandCommandRequestValidator _validator;

    public CreateVehicleBrandCommandRequestValidatorTests()
    {
        _validator = new CreateVehicleBrandCommandRequestValidator();
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsEmpty()
    {
        // Arrange
        var model = new CreateVehicleBrandCommandRequest(string.Empty);

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsTooShort()
    {
        // Arrange
        var model = new CreateVehicleBrandCommandRequest("A");

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name);
    }

    [Fact]
    public async Task Should_HaveError_WhenNameIsTooLong()
    {
        // Arrange
        var model = new CreateVehicleBrandCommandRequest(new string('A', 65));

        // Act
        var result = await _validator.TestValidateAsync(model);

        // Assert
        result.ShouldHaveValidationErrorFor(x => x.Name);
    }
}