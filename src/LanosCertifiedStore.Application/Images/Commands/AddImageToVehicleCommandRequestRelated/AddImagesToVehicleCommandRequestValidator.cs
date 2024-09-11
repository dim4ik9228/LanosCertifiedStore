using FluentValidation;
using Microsoft.AspNetCore.Http;

namespace LanosCertifiedStore.Application.Images.Commands.AddImageToVehicleCommandRequestRelated;

internal sealed class AddImagesToVehicleCommandRequestValidator : AbstractValidator<AddImagesToVehicleCommandRequest>
{
    private const int MinimalFileSize = 0;

    public AddImagesToVehicleCommandRequestValidator()
    {
        RuleFor(x => x.Images)
            .NotEmpty()
            .ForEach(image => image.Must(IsImageFile));

        RuleFor(x => x.Images.Select(i => i.Length))
            .ForEach(i => i.GreaterThan(MinimalFileSize));

        RuleFor(x => x.VehicleId)
            .NotEmpty();
    }

    private static bool IsImageFile(IFormFile imageFile) =>
        string.Equals(imageFile.ContentType, "image/jpg", StringComparison.OrdinalIgnoreCase) ||
        string.Equals(imageFile.ContentType, "image/jpeg", StringComparison.OrdinalIgnoreCase) ||
        string.Equals(imageFile.ContentType, "image/png", StringComparison.OrdinalIgnoreCase);
}