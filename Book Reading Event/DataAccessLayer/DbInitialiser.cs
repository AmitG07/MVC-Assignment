using Book_Reading.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public static class DbInitialiser
    {
        public static async Task InitialiseAsync(IServiceProvider serviceProvider, UserManager<ApplicationUser> _userManager)
        {
            var RoleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            string role = "Admin";
            IdentityResult result;
            var roleExists = await RoleManager.RoleExistsAsync(role);
            if (!roleExists)
            {
                result = await RoleManager.CreateAsync(new IdentityRole(role));
            }

            string Email = "myadmin@bookevents.com";
            string password = "Admin@123";
            if (_userManager.FindByEmailAsync(Email).Result == null)
            {
                ApplicationUser user = new ApplicationUser();
                user.Email = Email;
                user.UserName = Email;

                IdentityResult resultIdentity = _userManager.CreateAsync(user, password).Result;
                if (resultIdentity.Succeeded)
                {
                    _userManager.AddToRoleAsync(user, "Admin").Wait();
                }

            }
        }

    }
}
