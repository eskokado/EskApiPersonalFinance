using EskApiPersonalFinance.Domain.Interfaces.Services;
using EskApiPersonalFinance.Services.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EskApiPersonalFinance.Infra.CrossCutting.InversionOfControl
{
    public static class ServiceDependency
    {
        public static void AddServiceDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ILaunchService, LaunchService>();
        }
    }
}
