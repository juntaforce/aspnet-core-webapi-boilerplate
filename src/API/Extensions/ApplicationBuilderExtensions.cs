using Microsoft.AspNetCore.Builder;

namespace WebApi.Boilerplate.API.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder UseSwaggerDocumentation(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebApi.Boilerplate.API v1"));
            return app;
        }
    }
}