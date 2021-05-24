using System;
using System.Linq;
using System.Threading.Tasks;
using MagentaSportwear.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AspNetCoreTodo
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

            await roleManager.CreateAsync(
                new IdentityRole(Constants.AdministratorRole));
        }

        private static async Task EnsureTestAdminAsync( UserManager<ApplicationUser> userManager )
        {
            var testAdmin = await userManager.Users.Where(x => x.Email == "lucasjkjk@gmail.com").SingleOrDefaultAsync();

            if (testAdmin != null) return;

            testAdmin = new ApplicationUser
            {
                Email = "lucasjkjk@gmail.com"
            };
            //await userManager.CreateAsync( testAdmin, "12345Aa_");
            await userManager.AddToRoleAsync( testAdmin, Constants.AdministratorRole);
        }
    }
}
