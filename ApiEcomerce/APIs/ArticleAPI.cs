using Microsoft.AspNetCore.Mvc;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcomerce.APIs
{
    [Produces("application/json")]
    [Route("api/article")]
    [ApiController]
    public class ArticleAPI : Controller
    {
        private DBContext db;
        public ArticleAPI(DBContext dBContext) => db = dBContext;

        [HttpGet]
        public async Task<IActionResult> Gets()
        {
            return Ok();
        }
    }
}
