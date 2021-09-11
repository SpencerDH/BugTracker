using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BugTracker.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using BugTracker.Data;
using BugTracker.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<AppUser> UserMgr { get; }
        private SignInManager<AppUser> SignInMgr { get; }
        private readonly RaidContext _context;

        public AccountController(RaidContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _context = context;
            UserMgr = userManager;
            SignInMgr = signInManager;
        }

        public ActionResult Login(LoginViewModel? viewModel)
        {
            // Check if viewmodel exists
            if (viewModel == null)
            {
                LoginViewModel replacementViewModel = new LoginViewModel
                {
                    LoginSettings = "default"
                };

                return View(replacementViewModel);
            }

            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(IFormCollection fc)
        {
            // Define settings variable
            LoginViewModel viewModel = new LoginViewModel();

            // Load in the username and password passed to the form in Login.cshtml
            string userName = fc["Username"];
            string password = fc["Password"];

            // Handle case where username is empty
            if (userName.Length == 0)
            {
                viewModel.LoginSettings = "missing-username";
                return View(viewModel);
            }

            // Handle case wehre password is empty
            if (password.Length == 0)
            {
                viewModel.LoginSettings = "missing-password";
                return View(viewModel);
            }

            // Get the user with the username passed to the form
            var user = await _context.AppUsers
                .FirstOrDefaultAsync(au => au.UserName == userName);

            // Handle case where user is null
            if (user == null)
            {
                viewModel.LoginSettings = "user-does-not-exist";
                return View(viewModel);
            }

            // Check if password is correct
            var passwordCheck = await UserMgr.CheckPasswordAsync(user, password);

            if (passwordCheck == false)
            {
                viewModel.LoginSettings = "password-incorrect";
                return View(viewModel);
            }

            // Actually sign in the user
            var result = await SignInMgr.PasswordSignInAsync(user, password, false, false);
            
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Result = "result is: " + result.ToString();
            }

            // If something has gone wrong that's unaccounted for, return to the default login page
            viewModel.LoginSettings = "default";

            return View(viewModel);
        }

        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(IFormCollection fc)
        {
            // Assign username and password variables
            string userName = fc["Username"];
            string password = fc["Password"];
            string firstName = fc["FirstName"];
            string lastName = fc["LastName"];

            // Test to make sure the username isn't already in use
            var user = await UserMgr.FindByNameAsync(userName);

            // If username is already in use, redirect
            if (user != null)
            {
                // Need to throw some kind of error message here
                // Currently it just returns the user to the register page like nothing happened
                return RedirectToAction(nameof(Register));
            }

            // Create the user with the information passed in
            user = new AppUser
            {
                FirstName = firstName,
                LastName = lastName,
                UserName = userName
            };

            IdentityResult result = await UserMgr.CreateAsync(user, password);
            Console.WriteLine("User registration results");
            Console.WriteLine(IdentityResult.Success);

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();

            return RedirectToAction("Login");
        }
    }
}
