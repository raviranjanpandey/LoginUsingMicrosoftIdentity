using Domain.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Data
{
    public class SeedData
    {
        public static async Task Seed(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var defaultUsers = new List<AppUser>
                {
                    new AppUser
                    {
                        UserName = "Admin",
                        Email = "admin@example.com",
                        PhoneNumber = "9876543210"
                    }
                };

                foreach (AppUser user in defaultUsers)
                {
                    await userManager.CreateAsync(user, "Admin@123");
                }
            }
        }
    }
}
