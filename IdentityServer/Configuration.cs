using IdentityModel;
using IdentityServer4.Models;
using System.Collections.Generic;

namespace IdentityServer
{
    public class Configuration
    {
        public static IEnumerable<ApiResource> GetApiResources() =>
            new List<ApiResource> {
                new ApiResource("ApiIdentityServerSecure")
            };

        public static IEnumerable<Client> GetClients() =>
            new List<Client> {
                new Client {
                    ClientId = "client_id",
                    ClientSecrets = { new Secret("client_secret".ToSha256())},
                    AllowedGrantTypes = { GrantType.ClientCredentials },

                    AllowedScopes = { "ApiOne" }
                }
            };


    }
}
