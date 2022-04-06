using Microsoft.OpenApi.Models;

namespace MyTest_eCommerce.API.Config {
    public static class SwaggerConfig {

        public static void ConfigAddSwagger(this IServiceCollection services)
            => services.AddSwaggerGen(c => {
                c.SwaggerDoc("v1", new OpenApiInfo {
                    Title = "MyTest-eCommerce",
                    Description = "App teste do Bootcamp Way2",
                    Version = "v1"
                });
            });

        public static void ConfigUseSwagger(this WebApplication app) {
            app.UseSwagger();
            app.UseSwaggerUI(c => {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "MyTest-eCommerce v1");
                c.RoutePrefix = string.Empty;
            });
        }
    }
}
