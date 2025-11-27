using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using TechStore.Shared.Constants;

namespace TechStore.Infrastructure.Identity
{
    public class RoleSeed
    {
        public static async Task RoleSeedAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if(! await roleManager.RoleExistsAsync(Roles.Admin))
            {
                var admin = new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = Roles.Admin,
                    NormalizedName = Roles.Admin.ToUpper(),

                };

                await roleManager.CreateAsync(admin);
            }
            if(! await roleManager.RoleExistsAsync(Roles.User))
            {
                var user = new IdentityRole
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper(),
                };

                await roleManager.CreateAsync(user);
            }
        }
    }
}
