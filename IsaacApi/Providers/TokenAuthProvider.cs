using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http.Authentication;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace IsaacApi.Providers
{
    internal class TokenAuthProvider : ISecureDataFormat<AuthenticationTicket>
    {
        private readonly string _algorithm;
        private readonly TokenValidationParameters _validationParameters;

        public TokenAuthProvider(string algorithm, TokenValidationParameters validationParameters)
        {
            _algorithm = algorithm;
            _validationParameters = validationParameters;
        }

        public string Protect(AuthenticationTicket data)
        {
            throw new NotImplementedException();
        }

        public string Protect(AuthenticationTicket data, string purpose)
        {
            throw new NotImplementedException();
        }

        public AuthenticationTicket Unprotect(string protectedText) => Unprotect(protectedText, null);
        

        public AuthenticationTicket Unprotect(string protectedText, string purpose)
        {
            var handler = new JwtSecurityTokenHandler();
            ClaimsPrincipal principal = null;
            SecurityToken validToken = null;

            try {
                principal = handler.ValidateToken(protectedText, this._validationParameters, out validToken);
                var validJwt = validToken as JwtSecurityToken;

                if (validJwt == null)
                    throw new Exception();
            }
            catch (Exception)
            { return null; }

            return new AuthenticationTicket(principal, new AuthenticationProperties(), "Cookie");
        }
    }
}
