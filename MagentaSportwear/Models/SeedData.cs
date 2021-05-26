using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MagentaSportwear.Models
{
    public static class SeedData
    {
        public static async Task InitializeAsync(
            IServiceProvider services)
        {
            var roleManager = services
                .GetRequiredService<RoleManager<IdentityRole>>();

            await EnsureRolesAsync(roleManager);

            var userManager = services
                .GetRequiredService<UserManager<ApplicationUser>>();

            await EnsureTestAdminAsync(userManager);
        }

        private static async Task EnsureRolesAsync( RoleManager<IdentityRole> roleManager )
        {
            var alreadyExists = await roleManager
                .RoleExistsAsync(Constants.AdministratorRole);

            if (alreadyExists) return;

            await roleManager.CreateAsync(new IdentityRole(Constants.AdministratorRole));
        }

        private static async Task EnsureTestAdminAsync( UserManager<ApplicationUser> userManager )
        {
            var testAdmin = await userManager.Users.Where(x => x.Email == "admin@magenta").SingleOrDefaultAsync();

            if (testAdmin == null)
            {
                testAdmin = new ApplicationUser
                {
                    UserName = "admin@magenta",
                    Email = "admin@magenta"
                };

                await userManager.CreateAsync(testAdmin, "kho257Lucas_");
            }

            await userManager.AddToRoleAsync( testAdmin, Constants.AdministratorRole);
            await userManager.UpdateAsync(testAdmin);
        }
    }
}
