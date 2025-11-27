using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TechStore.Application.DTOs;
using TechStore.Shared.Constants;
using TechStore.WebAPI.Auth;
using TechStore.WebAPI.Filters;

namespace TechStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IJwtRepository _jwtRepository;

        public AuthController(UserManager<IdentityUser> userManager, IJwtRepository jwt)
        {
            _userManager = userManager;
            _jwtRepository = jwt;
        }

        [HttpPost]
        [Route("Register")]
        [ValidateModelAttribute]
        public async Task<IActionResult> Register([FromBody] RegisterReqDTO reqDTO)
        {
            if(reqDTO == null)
            {
                return BadRequest("Bad request null or empty info!");
            }

            if(reqDTO.Password == reqDTO.PasswordConfirmation)
            {
                var user = new IdentityUser
                {
                    Email = reqDTO.Email,
                    UserName = reqDTO.Email,
                    EmailConfirmed = false,
                    NormalizedEmail = reqDTO.Email!.ToUpper(),
                    NormalizedUserName = reqDTO.Email!.ToUpper()
                };

                var result = await _userManager.CreateAsync(user, reqDTO.Password!);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Roles.User);

                    return Ok("User Register successful!");
                }
            }

            return BadRequest("Can'y register user!");
        }



        [HttpPost]
        [Route("Login")]
        [ValidateModelAttribute]
        public async Task<IActionResult> Login([FromBody] LoginReqDTO reqDTO)
        {
            if (reqDTO == null)
            {
                return BadRequest("Not found user!");
            }

            var user = await _userManager.FindByEmailAsync(reqDTO.Email!);

            if(user != null)
            {
                var checkedPassword = await _userManager.CheckPasswordAsync(user, reqDTO.Password!);

                if(checkedPassword)
                {
                    var token = _jwtRepository.CreateJwt(user, "User");

                    return Ok(new {Jwt =  token});
                }
            }

            return NotFound("Not found user!");
        }
    }
}
