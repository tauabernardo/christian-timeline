using HistoryOfChristianity.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace HistoryOfChristianity.Infrastructure.IoC;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureMVC(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
        {
            options.UseNpgsql(connectionString,
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName))
            .EnableSensitiveDataLogging();
        });

        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        //services.AddDefaultIdentity<ApplicationUser>(options =>
        //    options.SignIn.RequireConfirmedAccount = false)
        //    .AddRoles<IdentityRole>()
        //    .AddEntityFrameworkStores<ApplicationDbContext>();

        return services;
    }
}
