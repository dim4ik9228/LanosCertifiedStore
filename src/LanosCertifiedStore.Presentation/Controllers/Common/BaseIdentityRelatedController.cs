﻿namespace LanosCertifiedStore.Presentation.Controllers.Common;

// public abstract class BaseIdentityRelatedController : BaseApiController
// {
//     private protected override ActionResult HandleResult<T>(Result<T> result)
//     {
//         return result switch
//         {
//             IValidationResult validationResult => BadRequest(CreateProblemDetails("Validation Error",
//                 BadRequest().StatusCode, result.Error!, validationResult.Errors)),
//             _ => result.IsSuccess switch
//             {
//                 true => Ok(result.Value),
//                 false => BadRequest(result.Error!.Message)
//             }
//         };
//     }
// }