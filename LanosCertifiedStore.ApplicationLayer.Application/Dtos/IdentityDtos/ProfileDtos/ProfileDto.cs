﻿namespace Application.Dtos.IdentityDtos.ProfileDtos;

public sealed record ProfileDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public string Email { get; set; } = default!;
}
