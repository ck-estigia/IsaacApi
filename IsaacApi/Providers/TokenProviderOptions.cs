using Microsoft.IdentityModel.Tokens;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IsaacApi.Providers
{
    internal class TokenProviderOptions
    {
        public string Path { set; get; } = "/token";
        public string Issuer { set; get; }
        public string Audience { set; get; }
        public TimeSpan Expiration { set; get; } = TimeSpan.FromMinutes(5);
        public SigningCredentials SigningCredentials { set; get; }
        public Func<string, string, Task<ClaimsIdentity>> IdentityResolver {set; get;}
        public Func<Task<string>> NonceGenerator { get; set; } = () => Task.FromResult(Guid.NewGuid().ToString());

    }
}
