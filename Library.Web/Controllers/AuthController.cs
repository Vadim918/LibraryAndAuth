using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Library.Core.Repositories;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Web.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUnitOfWork _uow;

        public AuthController(IUnitOfWork uow) => _uow = uow;

        [Route("[action]")]
        public IActionResult Login(string returnUrl)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Login(string email, string password, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;

            if (string.IsNullOrEmpty(email))
            {
                ModelState.AddModelError("email", "Email cannot be empty");
            }
            else if (email.Length < 4 || email.Length > 128)
            {
                ModelState.AddModelError("email", "Email's length must be [4..128]");
            }

            if (string.IsNullOrEmpty(password))
            {
                ModelState.AddModelError("password", "Password cannot be empty");
            }
            else if (password.Length < 5 || password.Length > 128)
            {
                ModelState.AddModelError("password", "Password's length must be [5..128]");
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = _uow.UserRepository.FindByEmail(email);
            if (user == null || user.PasswordHash != password)
            {
                return View(LoginResult.IncorrectPassword);
            }

            var claims = new List<Claim>
            {
                new Claim("userId", user.Id.ToString()),
                new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}")
            };
            claims.AddRange(user.UserRoles.Select(x => new Claim(ClaimTypes.Role, x.Role.Name)));

            var principal = new ClaimsPrincipal(new ClaimsIdentity(claims, "LibraryType"));
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal,
                new AuthenticationProperties {AllowRefresh = true});

            if (string.IsNullOrEmpty(returnUrl))
            {
                return RedirectToAction("Index", "Home");
            }

            return Redirect(returnUrl);
        }

        [Authorize]
        [Route("[action]")]
        public async Task<IActionResult> Logoff()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}