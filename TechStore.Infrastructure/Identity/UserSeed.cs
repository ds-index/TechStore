using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using TechStore.Shared.Constants;

namespace TechStore.Infrastructure.Identity
{
    public class UserSeed
    {

        public static async Task UserSeedAsync(IServiceProvider serviceProvider)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            await CreateUserWithRoleAsync(userManager, "Arman@test.com", "Arman@1234", Roles.Admin);
            await CreateUserWithRoleAsync(userManager, "Sina@test.com", "Sina@1234", Roles.User);
            await CreateUserWithRoleAsync(userManager, "Sarah@test.com", "Sarah@1234", Roles.User);
        }


        private static async Task CreateUserWithRoleAsync(UserManager<IdentityUser> user,
            string email,
            string password,
            string role)
        {
            try
            {
                if (await user.FindByEmailAsync(email) == null)
                {
                    var newUser = new IdentityUser
                    {
                        Id = Guid.NewGuid().ToString(),
                        Email = email,
                        UserName = email,
                        EmailConfirmed = true,
                        NormalizedEmail = email.ToUpper(),
                        NormalizedUserName = email.ToUpper(),
                    };

                    var result = await user.CreateAsync(newUser, password);

                    if (result.Succeeded)
                    {
                        await user.AddToRoleAsync(newUser, role);
                    }
                    else
                    {
                        throw new Exception("Can't create new user with role!");
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
