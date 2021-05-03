using EskApiPersonalFinance.Domain.Interfaces.Repositories;
using EskApiPersonalFinance.Infra.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EskApiPersonalFinance.Infra.CrossCutting.InversionOfControl
{
    public static class SqlServerRepositoryDependency
    {
        public static void AddSqlServerRepositoryDependency(this IServiceCollection services)
        {
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IAccountRepository, AccountRepository>();
            services.AddScoped<ILaunchRepository, LaunchRepository>();
        }
    }
}
