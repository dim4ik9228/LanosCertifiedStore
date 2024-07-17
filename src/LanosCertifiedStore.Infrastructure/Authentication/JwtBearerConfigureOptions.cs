﻿using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace LanosCertifiedStore.InfrastructureLayer.Services.Authentication;

internal sealed class JwtBearerConfigureOptions(IConfiguration configuration) : IConfigureNamedOptions<JwtBearerOptions>
{
    private const string AuthenticationSectionName = "Authentication";
    
    public void Configure(JwtBearerOptions options)
    {
        configuration.GetSection(AuthenticationSectionName).Bind(options);
        options.UseSecurityTokenValidators = true;
    }

    public void Configure(string? name, JwtBearerOptions options)
    {
        Configure(options);
        options.UseSecurityTokenValidators = true;
    }
}