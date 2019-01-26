using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartup(typeof(zuwi.App_Start.Startup))]

namespace zuwi.App_Start
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "ApplicationCookie",
                LoginPath = new PathString("/Account/Login"),
                Provider = new CookieAuthenticationProvider(),
                CookieName = "ApplicationCookie",
                CookieHttpOnly = true,
                ExpireTimeSpan = TimeSpan.FromHours(1),
            });
        }
    }
}
