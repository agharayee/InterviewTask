using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data.Entities;
using Test.Web.Interfaces;
using Test.Web.Models;

namespace Test.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;
        private readonly SignInManager<ApplicationUser> _signinManager;

        public AccountController(SignInManager<ApplicationUser> signinManager, IAccountService accountService)
        {
           _signinManager = signinManager;
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        //POST Request to handle Logout process
        [HttpPost]
        public async Task<ActionResult> Logout()
        {
            await _signinManager.SignOutAsync();
            return LocalRedirect("~/");
        }

       //Get Request to handle Login Process
        public async Task<ActionResult> Login(LoginModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                var result = await _signinManager.PasswordSignInAsync(model.Email, model.Password, false, false);
                if(!result.Succeeded)
                {
                    ModelState.AddModelError("", "The Username or Password does not exist");
                    return View();
                }
                return LocalRedirect("~/");
            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            try
            {
                var user = await _accountService.CreateUsersAsync(model);
                await _signinManager.SignInAsync(user, isPersistent: false);
                return LocalRedirect("~/");
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }
    }
}
    