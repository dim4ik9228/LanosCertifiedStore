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
}