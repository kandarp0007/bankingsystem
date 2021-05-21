using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using banking.Models;
using banking.Repository;

namespace banking.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthenticateRepository _authenticateRepository;

        public HomeController(IAuthenticateRepository authenticateRepository )
        {
            _authenticateRepository = authenticateRepository;
        }

        public IActionResult Index()
        {

            return View();
        }
        public IActionResult login(bool isSuccess = false)
        {

            ViewBag.IsSuccess = isSuccess;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> login(LoginModel loginModel, string returnUrl)
        {

            ViewBag.IsSuccess = false;
            if (ModelState.IsValid)
            {
                var result = await _authenticateRepository.PasswordSignInAsync(loginModel);
                if(result.Succeeded)
                {
                    if(!string.IsNullOrEmpty(returnUrl))
                    {
                        return LocalRedirect(returnUrl);
                    }
                    return RedirectToAction("UserHome", "BankHome");
                }
                ModelState.AddModelError("", "Invalid Credentials");
            }

            return View();
        }
        public IActionResult Register(bool isSuccess = false)
        {

            ViewBag.IsSuccess = isSuccess;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel registerModel)
        {

            ViewBag.IsSuccess = false;
            if (ModelState.IsValid)
            {
                var result = await _authenticateRepository.createUserAsync(registerModel);
                if(!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError("", errorMessage.Description);
                    }
                    return View(registerModel);

                }
                ModelState.Clear();
                return RedirectToAction(nameof(login), new { isSuccess = true });
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Logout()
        {
            await _authenticateRepository.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
