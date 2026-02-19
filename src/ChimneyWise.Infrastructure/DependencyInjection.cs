// Copyright (c) 2026 ChimneyWise. All rights reserved. 
//  No warranty, explicit or implicit, provided.

using ChimneyWise.Core;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ChimneyWise.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        _ = services.AddCoreServices();
        return services;
    }
}
