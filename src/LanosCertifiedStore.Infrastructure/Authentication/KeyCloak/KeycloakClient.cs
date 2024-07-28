﻿using System.Net.Http.Json;
using LanosCertifiedStore.Application.Identity;

namespace LanosCertifiedStore.Infrastructure.Authentication.Keycloak;

internal sealed class KeycloakClient(HttpClient httpClient)
{
    private const string BaseRequestUri = "users";

    internal async Task<UserDataDto> GetUserDataAsync(
        Guid userId,
        CancellationToken cancellationToken = default)
    {
        var requestUri = BaseRequestUri + "/" + userId;

        var httpResponseMessage = await httpClient.GetAsync(requestUri, cancellationToken);

        httpResponseMessage.EnsureSuccessStatusCode();

        return (await httpResponseMessage.Content.ReadFromJsonAsync<UserDataDto>(cancellationToken))!;
    }
    
    internal async Task UpdateUserDataAsync(
        Guid userId,
        UserRepresentation user,
        CancellationToken cancellationToken = default)
    {
        var requestUri = BaseRequestUri + "/" + userId;

        var httpResponseMessage = await httpClient.PutAsJsonAsync(
            requestUri,
            user,
            cancellationToken);

        httpResponseMessage.EnsureSuccessStatusCode();
    }
}