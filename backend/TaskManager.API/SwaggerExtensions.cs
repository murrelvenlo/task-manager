using Microsoft.OpenApi.Models;

namespace TaskManager.API
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddSwaggerService(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Task Manager API",
                    Version = "v1",
                    Description = "This API is designed for managing tasks in the Task Manager application by Murrel Venlo.",
                    Contact = new OpenApiContact
                    {
                        Name = "Murrel Venlo",
                        Email = "venlo.mj@hotmail.nl",
                        Url = new System.Uri("https://example.com")
                    }
                });
            });

            return services;
        }
    }
}
