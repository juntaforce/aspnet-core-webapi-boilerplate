using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Boilerplate.Application.Constants;
using WebApi.Boilerplate.Application.Enums;

namespace WebApi.Boilerplate.Infrastructure.Identity.Seeds
{
    public static class DefaultBasicUser
    {
        public static async Task SeedAsync(UserManager<ExtendedIdentityUser> userManager)
        {
            var defaultUser = new ExtendedIdentityUser
            {
                UserName = DefaultIdentityConstants.DefaultBasicUser.UserName,
                Email = DefaultIdentityConstants.DefaultBasicUser.Email,
                FirstName = DefaultIdentityConstants.DefaultBasicUser.FirstName,
                LastName = DefaultIdentityConstants.DefaultBasicUser.LastName,
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                IsActive = true
            };
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, DefaultIdentityConstants.DefaultBasicUser.Password);
                    await userManager.AddToRoleAsync(defaultUser, Roles.Basic.ToString());
                }
            }
        }
    }
}