using LanosCertifiedStore.Application.Shared.ResultRelated;
using LanosCertifiedStore.Application.Vehicles;
using LanosCertifiedStore.Application.Vehicles.Commands.UpdateVehicleCommandRequestRelated;
using NSubstitute.ExceptionExtensions;

namespace ApplicationUnitTests.Vehicles.UpdateVehicleCommand;

public sealed class UpdateVehicleCommandHandlerTests
{
    private readonly IVehicleService _vehicleService = Substitute.For<IVehicleService>();
    private readonly UpdateVehicleCommandRequestHandler _requestHandler;
    private readonly UpdateVehicleCommandRequest _request = UpdateVehicleCommandTestExemplars.Regular();

    public UpdateVehicleCommandHandlerTests()
    {
        _requestHandler = new UpdateVehicleCommandRequestHandler(_vehicleService);
    }

    [Fact]
    public async Task Handler_ShouldInvokeUpdateVehicle_FromVehicleService()
    {
        // Arrange & Act
        await _requestHandler.Handle(_request, default);

        // Assert
        await _vehicleService
            .Received()
            .UpdateVehicle(Arg.Is<UpdateVehicleCommandRequest>(r => r == _request), Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handler_ShouldNotThrowIfResponseIsSuccessful()
    {
        // Arrange
        _vehicleService.UpdateVehicle(Arg.Any<UpdateVehicleCommandRequest>(), Arg.Any<CancellationToken>())
            .Returns(Task.CompletedTask);

        // Act
        var result = await _requestHandler.Handle(_request, default);

        // Assert
        result.IsSuccess
            .Should().BeTrue();
    }

    [Fact]
    public async Task Handler_ShouldReturnNotFoundError_WhenVehicleDoesNotExist()
    {
        // Arrange
        _vehicleService.UpdateVehicle(Arg.Any<UpdateVehicleCommandRequest>(), Arg.Any<CancellationToken>())
            .Throws<KeyNotFoundException>();

        // Act
        var result = await _requestHandler.Handle(_request, default);

        // Assert
        result.IsSuccess.Should().BeFalse();
        result.Error.Should().Be(Error.NotFound(_request.Id));
    }
}