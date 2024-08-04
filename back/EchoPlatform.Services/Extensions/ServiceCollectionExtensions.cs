using EchoPlatform.Inrastructure.Persistance;
using EchoPlatform.Inrastructure.Seed;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EchoPlatform.Inrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddInfrastructure(this IServiceCollection servises, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("EchoDb");
            servises.AddDbContext<ApplicationDbContext>(ops => ops.UseSqlServer(connectionString));

            servises.AddScoped<IEchoSeeder, EchoSeeder>();
        }
    }
}
