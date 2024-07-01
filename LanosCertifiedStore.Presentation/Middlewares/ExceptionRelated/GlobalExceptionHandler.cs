﻿using System.Net;
using API.Middlewares.ExceptionRelated.Common.Classes;

namespace API.Middlewares.ExceptionRelated;

internal sealed class GlobalExceptionHandler(
    ILogger<GlobalExceptionHandler> logger) : ExceptionHandlerBase<Exception>(
    logger,
    "InternalServerError",
    "Unexpected error has occured!",
    HttpStatusCode.InternalServerError);