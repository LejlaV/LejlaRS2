using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyDentalCare.WebAPI.Services;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging;
using System.Text.Encodings.Web;
using System.Net.Http.Headers;
using System.Text;
using System.Security.Claims;

namespace MyDentalCare.WebAPI.Security
{
	public class BasicAuthenticationHandler : AuthenticationHandler<AuthenticationSchemeOptions>
	{
        private readonly IKorisnikService _userService;
        private readonly ILoginService _userServiceLogin;
        public BasicAuthenticationHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IKorisnikService userService)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
        }

        private bool Pacijent = false;
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return AuthenticateResult.Fail("Missing Authorization Header");

            Model.KorisnikLogin user = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                user = _userServiceLogin.Authenticiraj(username, password);

                if (user == null)
                {
                    user = _userServiceLogin.AuthenticirajPacijenta(username, password);
                    Pacijent = true;
                }
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (user == null)
                return AuthenticateResult.Fail("Invalid Username or Password");


            var claims = new List<Claim> {
                new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme),
                new Claim(ClaimTypes.Name, user.Ime),
            };

            if (!Pacijent)
            {
                foreach (var role in user.KorisnikUloge)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.Uloga.Naziv));
                }
            }

            foreach (var role in user.KorisnikUloge)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Uloga.Naziv));
            }

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            return AuthenticateResult.Success(ticket);
        }
    }
}
