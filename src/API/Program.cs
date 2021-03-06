using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using WebApi.Boilerplate.API.Extensions;
using WebApi.Boilerplate.Infrastructure.Contexts;
using WebApi.Boilerplate.Infrastructure.Identity;

namespace WebApi.Boilerplate.API
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            using var scope = host.Services.CreateScope();
            var services = scope.ServiceProvider;
            var loggerFactory = services.GetRequiredService<ILoggerFactory>();
            var logger = loggerFactory.CreateLogger<Program>();
            try
            {
                var context = services.GetRequiredService<ApplicationDbContext>();
                await context.Database.MigrateAsync();
                var userManager = services.GetRequiredService<UserManager<ExtendedIdentityUser>>();
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
                await Infrastructure.Identity.Seeds.DefaultRoles.SeedAsync(roleManager);
                await Infrastructure.Identity.Seeds.DefaultAdministrator.SeedAsync(userManager);
                await Infrastructure.Identity.Seeds.DefaultBasicUser.SeedAsync(userManager);
                logger.LogInformation("Finished Seeding Default Data.");
                logger.LogInformation("Application Starting.");
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);
            }
            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
             .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}