﻿using LanosCertifiedStore.Application.Shared.ValidationRelated;
using LanosCertifiedStore.Application.Vehicles.Commands.CreateVehicle;
using LanosCertifiedStore.Application.Vehicles.Dtos;
using LanosCertifiedStore.Infrastructure.Authorization;
using LanosCertifiedStore.Presentation.Controllers.Common;
using Microsoft.AspNetCore.Mvc;

namespace LanosCertifiedStore.Presentation.Controllers.VehicleRelated;

[Route("api/vehicles")]
public sealed class VehiclesController : BaseApiController
{
    // [HttpGet]
    // [ProducesResponseType(typeof(PaginationResult<VehicleDto>), StatusCodes.Status200OK)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<PaginationResult<VehicleDto>>> GetVehicles(
    //     [FromQuery] VehicleFilteringRequestParameters requestParameters)
    // {
    //     return HandleResult(await Mediator.Send(new VehiclesQuery(requestParameters)));
    // }
    //
    [HttpGet("{id:guid}", Name = "GetVehicleById")]
    // [ProducesResponseType(typeof(VehicleDto), StatusCodes.Status200OK)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status404NotFound)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<VehicleDto>> GetVehicle(Guid id)
    {
        throw new NotImplementedException();
    }
    //
    // [HttpGet("countItems")]
    // [ProducesResponseType(typeof(ItemsCountDto), StatusCodes.Status200OK)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    // [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<ItemsCountDto>> GetItemsCount(
    //     [FromQuery] VehicleFilteringRequestParameters requestParameters)
    // {
    //     return HandleResult(await Mediator.Send(new CountVehiclesQueryRequest(requestParameters)));
    // }
    //
    // [HttpGet("getPriceRange")]
    // [ProducesResponseType(typeof(Dictionary<string, decimal>), StatusCodes.Status200OK)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    // [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult<Dictionary<string, decimal>>> GetPriceRange(
    //     [FromQuery] VehicleFilteringRequestParameters requestParameters)
    // {
    //     return HandleResult(await Mediator.Send(new VehiclePriceRangeQuery(requestParameters)));
    // }

    [HasAccessPermission("vehicles:create")]
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Guid>> CreateVehicle(CreateVehicleCommandRequest request)
    {
        var result = await Sender.Send(request);

        if (result is IValidationResult validationResult)
        {
            return BadRequest(CreateValidationProblemDetails(result.Error!, validationResult.Errors));
        }

        return CreatedAtRoute("GetVehicleById", new { id = result.Value }, result.Value);
    }

    // [HttpPut]
    // [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    // [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult> UpdateVehicle([FromBody] UpdateVehicleCommand updateVehicleCommand)
    // {
    //     return HandleResult(await Mediator.Send(updateVehicleCommand));
    // }
    //
    // [HttpDelete]
    // [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    // public async Task<ActionResult> DeleteVehicle([FromBody] DeleteVehicleCommand deleteVehicleCommand)
    // {
    //     return HandleResult(await Mediator.Send(deleteVehicleCommand));
    // }
    //
    // [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    // [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    // [HttpPost("addImage")]
    // public async Task<ActionResult> AddImageToVehicle([FromForm] AddImageToVehicleCommand addImageToVehicleCommand)
    // {
    //     return HandleResult(await Mediator.Send(addImageToVehicleCommand));
    // }
    //
    // [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    // [HttpDelete("deleteImage")]
    // public async Task<ActionResult> DeleteImageFromVehicle(
    //     [FromBody] RemoveImageFromVehicleCommand removeImageFromVehicleCommand)
    // {
    //     return HandleResult(await Mediator.Send(removeImageFromVehicleCommand));
    // }
    //
    // [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
    // [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    // [HttpPost("setMainImage")]
    // public async Task<ActionResult> SetVehicleMainImage(
    //     [FromBody] SetVehicleMainImageCommand setVehicleMainImageCommand)
    // {
    //     return HandleResult(await Mediator.Send(setVehicleMainImageCommand));
    // }
}