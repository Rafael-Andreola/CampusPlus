using Domain.Interfaces;
using Domain.Interfaces.Repositories;
using Domain.Repositories;
using Domain.Services;

namespace Application.Middlewares
{
    public static class ServiceConfiguration
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddMvc();

            services.AddScoped<IDisciplinaService, DisciplinaService>();
            services.AddScoped<IDisciplinaRepository, DisciplinaRepository>();

            //services.AddTransient<ProductRepository, ProductRepository>();
        }
    }
}
