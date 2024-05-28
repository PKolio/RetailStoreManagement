using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace YourProjectNamespace.Configuration
{
    public static class SwaggerConfiguration
    {
        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "RetailStoreManagement", Version = "v1" });
            });
        }
    }
}
