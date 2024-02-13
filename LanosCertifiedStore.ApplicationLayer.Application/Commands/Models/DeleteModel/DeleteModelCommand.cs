﻿using Application.Core;
using MediatR;

namespace Application.Commands.Models.DeleteModel;

public sealed record DeleteModelCommand(Guid Id) : IRequest<Result<Unit>>;