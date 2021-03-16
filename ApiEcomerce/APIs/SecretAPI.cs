using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcomerce.APIs
{
    [Route("api/[controller]")]
    [ApiController]
    [Route("api/account")]
    [Authorize]

    public class SecretAPI : ControllerBase
    {
        public string Index()
        {
            return "secret message from identity server secure";
        }
    }
}
