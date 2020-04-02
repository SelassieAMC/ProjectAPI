using Microsoft.Extensions.DependencyInjection;

namespace BarberShop.API.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddSwaggerDoc(this IServiceCollection services){
            return services.AddSwaggerDocument(config =>
            {
                config.PostProcess = document =>
                {
                    document.Info.Version = "v1";
                    document.Info.Title = "BarberShop API";
                    document.Info.Description = "API for BarberShop and BeautyStudio";
                    document.Info.Contact = new NSwag.OpenApiContact
                    {
                        Name = "Andres M Clavijo M",
                        Email = "andrclam@outlook.com"
                    };
                };
            });
        }
    }
}