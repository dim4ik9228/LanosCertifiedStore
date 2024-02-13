﻿using Application.Core;
using Application.Dtos.ColorDtos;
using MediatR;

namespace Application.Commands.Colors.UpdateColor;

public sealed record UpdateColorCommand(UpdateColorDto UpdateColorDto) : IRequest<Result<Unit>>;