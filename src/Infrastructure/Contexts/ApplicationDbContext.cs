using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using WebApi.Boilerplate.Domain.Entities;
using WebApi.Boilerplate.Infrastructure.Configurations;
using WebApi.Boilerplate.Infrastructure.Identity;

namespace WebApi.Boilerplate.Infrastructure.Contexts
{
    public class ApplicationDbContext : IdentityDbContext<ExtendedIdentityUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {         
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.ApplyIdentityConfiguration();
        }
    }
}