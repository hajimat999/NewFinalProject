using FinallyFinalProject.HomeVModels;
using FinallyFinalProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinallyFinalProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVModel registerVModel)
        {
            if (!ModelState.IsValid) return View();
            AppUser user = new AppUser
            {
                FirstName = registerVModel.FirstName,
                LastName = registerVModel.LastName,
                UserName=registerVModel.UserName,
                Email = registerVModel.Email, 
 
            };
            IdentityResult result = await userManager.CreateAsync(user, registerVModel.Password);
            if (!result.Succeeded)
            {
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await userManager.AddToRoleAsync(user, "Member");
            return RedirectToAction("Index", "Home");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVModel loginVModel)
        {

            if (!ModelState.IsValid) return View();

            AppUser user = await userManager.FindByNameAsync(loginVModel.UserName);
            if (user is null)
            {
                ModelState.AddModelError("", "Username or password is incorrect");
                return View();
            }

            Microsoft.AspNetCore.Identity.SignInResult result = await signInManager.PasswordSignInAsync(user, loginVModel.Password, loginVModel.RememberMe, true);
            if (!result.Succeeded)
            {
                if (result.IsLockedOut)
                {
                    ModelState.AddModelError("", "You have been blocked about 10 minutes");
                    return View();
                }

                ModelState.AddModelError("", "Username or password is incorrect");
                return View();
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
       
        
    }
}
