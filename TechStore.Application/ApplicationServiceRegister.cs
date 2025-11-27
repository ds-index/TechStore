using Microsoft.Extensions.DependencyInjection;

namespace TechStore.Application
{
    public static class ApplicationServiceRegister
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection services)
        {
            var assembly = typeof(ApplicationServiceRegister).Assembly;

            services.AddAutoMapper(assembly);

            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssembly(assembly);
            });

            return services;
        }
    }
}
