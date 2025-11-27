using Microsoft.AspNetCore.Identity;

namespace TechStore.WebAPI.Auth
{
    public interface IJwtRepository
    {
        string CreateJwt(IdentityUser user, string role);
    }
}
