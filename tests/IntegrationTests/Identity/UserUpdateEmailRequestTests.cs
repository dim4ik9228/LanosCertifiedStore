﻿using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using IntegrationTests.Common;
using LanosCertifiedStore.Application.Identity.Commands.UserEmailUpdateCommandRequestRelated;
using LanosCertifiedStore.Domain.Entities.UserRelated;
using LanosCertifiedStore.Infrastructure.Authentication.KeyCloak;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace IntegrationTests.Identity;

public sealed class UserUpdateEmailRequestTests(
    IntegrationTestsWebApplicationFactory factory) : IntegrationTestBase(factory)
{
    [Fact]
    public async Task Endpoint_Should_ReturnNoContent_IfSenderHasPermission_AndRequestIsValid()
    {
        // Arrange
        var user = await RegisterUserOnKeycloakAndAddToDb(
            Faker.Internet.Email(),
            Faker.Internet.Password(),
            Faker.Phone.UkrainianPhoneNumber(),
            UserRole.Administrator);

        var token = await GetAccessTokenAsync(user.Email, user.Credentials.First().Value);

        var request = new UserEmailUpdateCommandRequest(Faker.Internet.Email());

        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            JwtBearerDefaults.AuthenticationScheme,
            token);

        // Act
        var response = await HttpClient.PutAsJsonAsync("api/identity/updateEmail", request);

        // Assert
        response.StatusCode
            .Should().Be(HttpStatusCode.NoContent);
    }

    [Fact]
    public async Task Send_Should_AddUpdateEmailRequiredActionToKeycloakUser()
    {
        // Arrange
        var user = await RegisterUserOnKeycloakAndAddToDb(
            Faker.Internet.Email(),
            Faker.Internet.Password(),
            Faker.Phone.UkrainianPhoneNumber(),
            UserRole.Administrator);

        var token = await GetAccessTokenAsync(user.Email, user.Credentials.First().Value);

        var request = new UserEmailUpdateCommandRequest(Faker.Internet.Email());

        HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
            JwtBearerDefaults.AuthenticationScheme,
            token);

        // Act
        await HttpClient.PutAsJsonAsync("api/identity/updateEmail", request);
        var userRepresentation = await KeycloakClient.GetUserDataAsync(user.Id);

        // Assert
        userRepresentation.RequiredActions
            .Any(ra => ra.Equals(KeycloakRequiredActions.GetVerifyEmailCode().First()))
            .Should().BeTrue();
    }

    [Fact]
    public async Task Endpoint_Should_ReturnUnauthorized_IfTokenIsNotPresent()
    {
        // Act
        var responseMessage = await HttpClient.PutAsync($"api/identity/updateEmail", null);

        // Assert
        responseMessage.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }
}