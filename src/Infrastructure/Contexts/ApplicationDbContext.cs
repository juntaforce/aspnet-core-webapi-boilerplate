using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApi.Boilerplate.Infrastructure.Configurations;
using WebApi.Boilerplate.Infrastructure.Identity;

namespace WebApi.Boilerplate.Infrastructure.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ExtendedIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyIdentityConfiguration();
        }
    }
}