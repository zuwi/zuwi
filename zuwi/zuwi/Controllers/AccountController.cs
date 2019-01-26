using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace zuwi.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager _userManager = new UserManager();

        // GET: Login
        public ActionResult Index()
        {
            return RedirectToAction("Login");
        }

        public ActionResult Login()
        {
            if (User.Identity.IsAuthenticated) return Redirect("/");
            if (TempData["errors"] != null) ViewData["errors"] = TempData["errors"] as List<string>;
            return View();
        }

        public ActionResult Register()
        {
            if (User.Identity.IsAuthenticated) return Redirect("/");
            if (TempData["errors"] != null) ViewData["errors"] = TempData["errors"] as List<string>;
            return View();
        }

        public ActionResult RegisterUser(string email, string password, string repeatPassword)
        {
            List<string> errors = new List<string>();
            bool check = true;
            if (password != repeatPassword)
            {
                errors.Add("The two password do not match.");
                check = false;
            }

            if (_userManager.UserExists(email))
            {
                errors.Add("The email " + email + " already exists");
                check = false;

            }
            if(check)
            {
                _userManager.CreateUser(email, password);
                SignIn(email);
                return Redirect("/");
            }
            else
            {
                TempData["errors"] = errors;
                return RedirectToAction("Register");
            }
        }

        public ActionResult LoginUser(string email, string password)
        {
            if (_userManager.ValidateUser(email, password))
            {
                SignIn(email);
                return Redirect("/");
            }

            TempData["errors"] = new List<string>() {"Wrong email or password used."};
            return RedirectToAction("Login");
        }

        private void SignIn(string email)
        {
            var user = _userManager.GetUser(email);

            var ident = new ClaimsIdentity(
                new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, email),
                    new Claim("http://schemas.microsoft.com/accesscontrolservice/2010/07/claims/identityprovider",
                        "ASP.NET Identity", "http://www.w3.org/2001/XMLSchema#string"),

                    new Claim(ClaimTypes.Email, email)
                },
                DefaultAuthenticationTypes.ApplicationCookie);

            foreach (var role in user.Roles.ToList()) ident.AddClaim(new Claim(ClaimTypes.Role, role.Name));
            HttpContext.GetOwinContext().Authentication.SignIn(
                new AuthenticationProperties {IsPersistent = false}, ident);
        }

        public ActionResult Logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                HttpContext.GetOwinContext().Authentication.SignOut();
                return Redirect("/");
            }

            return View("Login");
        }
    }
}