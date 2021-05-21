using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using banking.Repository;
using banking.Data;
using banking.Models;
using Microsoft.AspNetCore.Authorization;
using banking.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace banking.Controllers
{
    [Authorize]
    public class BankHomeController : Controller
    {
        private readonly AccountRepository _AccountRepository = null;
        private readonly IUserService _userService;
        private readonly UserManager<IdentityUser> _userManager;



        public BankHomeController(AccountRepository accountRepository, IUserService userService, UserManager<IdentityUser> userManager)
        {
            _AccountRepository = accountRepository;
            _userService = userService;
            _userManager = userManager;

        }

        
        public IActionResult UserHome()
        {
            var userId = _userService.GetUserId();

            var isLoggedIn = _userService.IsAuthenticated();
            IdentityUser user = _userManager.FindByIdAsync(userId).Result;
            var email = user.Email;
            var data = _AccountRepository.GetAccounts(email);

            return View(data);
        }
        public IActionResult card()
        {
            return View();
        }


        public IActionResult Accounts()
        {

            var userId = _userService.GetUserId();

            var isLoggedIn = _userService.IsAuthenticated();
            IdentityUser user = _userManager.FindByIdAsync(userId).Result;
            var email = user.Email;
            var data = _AccountRepository.GetAccounts(email);
            return View(data);
        }



        public IActionResult AddAccount(bool isSuccess = false)
        {
            ViewBag.IsSuccess = isSuccess;
            return View();
        }
        [HttpPost]
        public IActionResult AddAccount(AccountModel account)
        {

            var userId = _userService.GetUserId();

            var isLoggedIn = _userService.IsAuthenticated();
            IdentityUser user = _userManager.FindByIdAsync(userId).Result;
            var email = user.Email;
            var phonenumber = long.Parse(user.PhoneNumber); 
            int id = _AccountRepository.AddNewAccount(account, email, phonenumber);
            if(id > 0)
            {
                return RedirectToAction(nameof(AddAccount), new { isSuccess = true});
            }

            return View();
        }


        public IActionResult transfer(int isSuccess = 2)
        {

            var userId = _userService.GetUserId();

            var isLoggedIn = _userService.IsAuthenticated();
            IdentityUser user = _userManager.FindByIdAsync(userId).Result;
            var email = user.Email;
            ViewBag.data = new SelectList(_AccountRepository.GetAccounts(email),"Id","AccountNumber");
            ViewBag.IsSuccess = isSuccess;
            return View();
        }

        [HttpPost]
        public IActionResult transfer(TransactionModel transaction)
        {
            if (ModelState.IsValid)
            {
                var userId = _userService.GetUserId();
                var isLoggedIn = _userService.IsAuthenticated();
                IdentityUser user = _userManager.FindByIdAsync(userId).Result;
                var email = user.Email;


                int id = _AccountRepository.Transaction(transaction, email);
                if (id > 0)
                {
                    return RedirectToAction(nameof(transfer), new { isSuccess = 1 });
                }
                if (id < 0)
                {
                    return RedirectToAction(nameof(transfer), new { isSuccess = -1 });
                }


                ViewBag.data = new SelectList(_AccountRepository.GetAccounts(email), "Id", "AccountNumber");
                return View();
            }
            return View();
        }

        public IActionResult Transaction()
        {
            var userId = _userService.GetUserId();
            var isLoggedIn = _userService.IsAuthenticated();
            IdentityUser user = _userManager.FindByIdAsync(userId).Result;
            var email = user.Email;
            ViewBag.data = new SelectList(_AccountRepository.GetAccounts(email), "Id", "AccountNumber");
            var data1 = _AccountRepository.GetTransactions(email);
            return View(data1);
        }
    }
}
