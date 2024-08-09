using LanosCertifiedStore.Application.Shared.ResultRelated;

namespace LanosCertifiedStore.Application.Images;

public static class ImageErrors
{
    public static Error UploadError(List<ImageResult> failedImageResults)
    {
        var message = $"{failedImageResults.Count} images have not been uploaded successfully!";

        message = failedImageResults.Aggregate(message,
            (current, result) => current + ("\n" + result.ErrorMessage));

        return new Error(
            "ImageUploadError",
            message
        );
    }

    public static readonly Error NoImages = new Error(
        "EmptyImagesCollection",
        "Resource does not have any related images");

    public static Error NotFound(string imageId) => new(
        "ImageNotFound",
        $"Image with Id {imageId} is not found!");

    public static readonly Error DeletingMainImage = new(
        "DeletingMainImage",
        "Can not delete a main image");

    public static readonly Error UnsuccessfulRemoval = new(
        "ImageDeletingFailure",
        "Failed to remove image from cloud provider");
}