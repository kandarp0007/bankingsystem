using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using banking.Models;
using Microsoft.AspNetCore.Identity;

namespace banking.Repository
{
    public class AuthenticateRepository : IAuthenticateRepository
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthenticateRepository(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }
        public async Task<IdentityResult> createUserAsync(RegisterModel userModel)
        {
            var user = new IdentityUser()
            {
                Email = userModel.Email,
                UserName = userModel.Email,
                PhoneNumber = userModel.PhoneNumber
            };
            var result = await _userManager.CreateAsync(user, userModel.Password);
            return result;
        }

        public async Task<SignInResult> PasswordSignInAsync(LoginModel loginModel)
        {
          var result = await _signInManager.PasswordSignInAsync(loginModel.Email, loginModel.Password, loginModel.RememberMe, false);
            return result;
        }

        public async Task SignOutAsync()
        {
            await _signInManager.SignOutAsync();
        }
    }
}
