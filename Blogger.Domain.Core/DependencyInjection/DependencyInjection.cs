﻿using Blogger.Domain.Core.UseCases.Users;
using Microsoft.Extensions.DependencyInjection;

namespace Blogger.Domain.Core.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        services.AddScoped<IUserService, UserService>();
        return services;
    }
}