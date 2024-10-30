using LanosCertifiedStore.Application.Images;
using LanosCertifiedStore.Application.Shared.ResultRelated;
using LanosCertifiedStore.Application.Vehicles;
using LanosCertifiedStore.Application.Vehicles.Commands.DeleteVehicleCommandRequestRelated;
using LanosCertifiedStore.Application.Vehicles.Dtos;
using LanosCertifiedStore.Application.Vehicles.Queries.SingleVehicleQueryRequestRelated;
using LanosCertifiedStore.Domain.Entities.VehicleRelated;

namespace ApplicationUnitTests.Vehicles.DeleteVehicleCommand;

public sealed class DeleteVehicleCommandHandlerTests
{
    private readonly IVehicleService _vehicleService = Substitute.For<IVehicleService>();
    private readonly IImageService _imageService = Substitute.For<IImageService>();
    private readonly DeleteVehicleCommandRequestHandler _requestHandler;
    private readonly DeleteVehicleCommandRequest _request = DeleteVehicleCommandTestExemplars.Regular();

    public DeleteVehicleCommandHandlerTests()
    {
        _requestHandler = new DeleteVehicleCommandRequestHandler(_vehicleService, _imageService);
    }

    [Fact]
    public async Task Handle_WhenVehicleNotFound_ShouldReturnNotFoundError()
    {
        // Arrange
        _vehicleService
            .GetVehicle(Arg.Any<SingleVehicleQueryRequest>(), Arg.Any<CancellationToken>())
            .Returns((SingleVehicleDto?)null);

        // Act
        var result = await _requestHandler.Handle(_request, default);

        // Assert
        result.Error.Should().Be(Error.NotFound(_request.Id));
        await _vehicleService
            .DidNotReceive()
            .DeleteVehicle(Arg.Any<Guid>(), Arg.Any<CancellationToken>());
    }

    [Fact]
    public async Task Handle_WhenVehicleFoundWithoutImages_ShouldDeleteVehicleOnly()
    {
        // Arrange
        var vehicle = new Vehicle { Id = _request.Id, Images = null };
        _vehicleService
            .GetVehicle(Arg.Any<SingleVehicleQueryRequest>(), Arg.Any<CancellationToken>())
            .Returns(new SingleVehicleDto
            {
                Id = vehicle.Id,
                Images = null
            });

        // Act
        var result = await _requestHandler.Handle(_request, default);

        // Assert
        result.Error.Should().Be(Error.None);
        await _vehicleService
            .Received()
            .DeleteVehicle(_request.Id, Arg.Any<CancellationToken>());
        await _imageService
            .DidNotReceive()
            .TryDeletePhotoAsync(Arg.Any<string>());
    }

    [Fact]
    public async Task Handle_WhenVehicleFoundWithEmptyImages_ShouldDeleteVehicleOnly()
    {
        // Arrange
        var vehicle = new Vehicle { Id = _request.Id, Images = new List<VehicleImage>() };
        _vehicleService
            .GetVehicle(Arg.Any<SingleVehicleQueryRequest>(), Arg.Any<CancellationToken>())
            .Returns(new SingleVehicleDto
            {
                Id = vehicle.Id,
                Images = []
            });

        // Act
        var result = await _requestHandler.Handle(_request, default);

        // Assert
        result.Error.Should().Be(Error.None);
        await _vehicleService
            .Received()
            .DeleteVehicle(_request.Id, Arg.Any<CancellationToken>());
        await _imageService
            .DidNotReceive()
            .TryDeletePhotoAsync(Arg.Any<string>());
    }

    [Fact]
    public async Task Handle_WhenVehicleFoundWithImages_ShouldDeleteVehicleAndImages()
    {
        // Arrange
        var images = new List<VehicleImage>
        {
            new() { CloudImageId = "image1" },
            new() { CloudImageId = "image2" }
        };
        var vehicle = new Vehicle { Id = _request.Id, Images = images };
        
        _vehicleService
            .GetVehicle(Arg.Any<SingleVehicleQueryRequest>(), Arg.Any<CancellationToken>())
            .Returns(new SingleVehicleDto
            {
                Id = vehicle.Id,
                Images = vehicle.Images.Select(x => new ImageDto{CloudImageId = x.CloudImageId})
            });

        // Act
        var result = await _requestHandler.Handle(_request, default);

        // Assert
        result.Error.Should().Be(Error.None);
        await _vehicleService
            .Received()
            .DeleteVehicle(_request.Id, Arg.Any<CancellationToken>());
        
        await _imageService
            .Received()
            .TryDeletePhotoAsync("image1");
        
        await _imageService
            .Received()
            .TryDeletePhotoAsync("image2");
    }
}