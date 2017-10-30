using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotoDrive.Dal.DatabaseModel;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using MotoDrive.Dal;
using MotoDrive.Web.Models.Authorisation;
using Microsoft.AspNetCore.Authentication.Cookies;
namespace MotoDrive.Web.Controllers
{
    public class AuthorisationController : Controller
    {
        private MotoDriveContext _context;

        public AuthorisationController(MotoDriveContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Registration(RegistrationModel model)
        {
            if (ModelState.IsValid)
            {
                User user = await _context.Users.FirstOrDefaultAsync(u => u.Mail == model.Email);

                if (user == null)
                {
                    user = new User { Mail = model.Email, Password = model.Password };
                    Role userRole = await _context.Roles.FirstAsync(u => u.Name == "user");

                    if (userRole != null)
                    {
                        user.Role = userRole;
                    }

                    _context.Add(user);

                    await _context.SaveChangesAsync();
                    await Authenticate(user);
                    return RedirectToAction("Index", "Home");
                }
                else ModelState.AddModelError("","Wrong password");
            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            return View();
        }

        public  async Task Authenticate(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType,user.Mail),
                new Claim(ClaimsIdentity.DefaultNameClaimType,user.Role?.Name)
            };

            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }

    }
}