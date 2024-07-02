﻿using System.Linq.Expressions;
using Domain.Entities.UserRelated;

namespace Persistence.Repositories.IdentityRelated.QueryBuilderRelated.Common.Classes;

internal abstract class UserSortingTypes
{
    public static readonly Dictionary<string, Expression<Func<User, object>>>
        Options = new()
        {
            { "firstName-desc", user => user.FirstName },
            { "firstName-asc", user => user.FirstName },
            { "lastName-desc", user => user.LastName },
            { "lastName-asc", user => user.LastName },
            { "email-desc", user => user.Email },
            { "email-asc", user => user.Email },
            { "default", user => user.FirstName }
        };
}