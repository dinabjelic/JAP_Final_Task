using DatingApp.API.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RecipesApp.Database;
using RecipesApp.Database.Entities;
using RecipesApp.Interfaces;
using RecipesApp.Models;
using System.Threading.Tasks;

namespace RecipesApp.Controllers
{
    public class AuthenticationController : BaseApiController
    {

        private readonly UserManager<IdentityUser<int>> _userManager;
        private readonly SignInManager<IdentityUser<int>> _signInManager;
        private readonly IConfiguration _confiuration;
        private readonly ITokenService _token;
        IPasswordHasher<IdentityUser<int>> _passwordHasher;

        public AuthenticationController(UserManager<IdentityUser<int>> userManager, RoleManager<IdentityRole<int>> roleManager,
            SignInManager<IdentityUser<int>> signInManager,
            IConfiguration confiuration, ITokenService token,
            IPasswordHasher<IdentityUser<int>> passwordHasher)
        {
            _token = token;
            _signInManager = signInManager;
            _userManager = userManager;
            _confiuration = confiuration;
            _passwordHasher = passwordHasher;
        }


        [HttpPost("login")]
        public async Task<ActionResult<GetUserRequest>> Login(RequestLoginDto loginModel)
        {

            var _user = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == loginModel.Username);
            if (_user == null)
            {
                return Unauthorized("Something went wrong, try again!");
            }

            var result = await _signInManager
            .CheckPasswordSignInAsync(_user, loginModel.Password, false);
            

            if (!result.Succeeded) return Unauthorized();

            MyUser user = new MyUser
            {
                Id = _user.Id
            };

            return new GetUserRequest
            {
                Username = _user.UserName,
                Token = _token.CreateToken(user)
            };
        }

        [HttpGet]
        public async Task<string> GetPassword()
        {
            var _user = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == "Dina");
            return _passwordHasher.HashPassword(_user, "test");
        }
    }
}









