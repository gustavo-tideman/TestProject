using Microsoft.Extensions.DependencyInjection;
using UnitTest.Application.Interface;
using UnitTest.Application.Services;
using UnitTest.Data.Context;
using UnitTest.Data.Interface;
using UnitTest.Data.Repository;

namespace UnitTest.Web.Configuration
{
    public static class DependencyInjection
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<TestDbContext>();
        }
    }
}