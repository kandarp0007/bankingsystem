using banking.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace banking.Repository
{
    public interface IAuthenticateRepository
    {
        Task<IdentityResult> createUserAsync(RegisterModel userModel);

        Task<SignInResult> PasswordSignInAsync(LoginModel loginModel);

        Task SignOutAsync();
    }
}