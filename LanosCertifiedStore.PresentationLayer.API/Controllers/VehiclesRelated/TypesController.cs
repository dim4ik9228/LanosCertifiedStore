﻿using API.Controllers.Common;
using API.Responses;
using Application.Commands.Types.CreateType;
using Application.Commands.Types.DeleteType;
using Application.Commands.Types.UpdateType;
using Application.Dtos.TypeDtos;
using Application.Queries.Types;
using Application.RequestParams;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.VehiclesRelated;

public sealed class TypesController : BaseEntityRelatedApiController
{
    [HttpGet]
    [ProducesResponseType(typeof(IReadOnlyList<TypeDto>), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IReadOnlyList<TypeDto>>> GetTypes(
        [FromQuery] VehicleTypeFilteringRequestParameters requestParameters)
    {
        return HandleResult(await Mediator.Send(new TypesQuery(requestParameters)));
    }

    [HttpPost]
    [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> CreateType([FromQuery] string name)
    {
        return HandleResult(await Mediator.Send(new CreateTypeCommand(name)));
    }

    [HttpPut]
    [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> UpdateType([FromBody] UpdateTypeDto updateTypeDto)
    {
        return HandleResult(await Mediator.Send(new UpdateTypeCommand(updateTypeDto)));
    }

    [HttpDelete("{id:guid}")]
    [ProducesResponseType(typeof(Unit), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ApiResponse), StatusCodes.Status400BadRequest)]
    public async Task<ActionResult> DeleteType(Guid id)
    {
        return HandleResult(await Mediator.Send(new DeleteTypeCommand(id)));
    }
}