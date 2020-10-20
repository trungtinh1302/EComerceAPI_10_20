using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Model;

namespace ApiEcomerce.API
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductAPI : Controller
    {
        private DBContext db;
        public ProductAPI(DBContext dbcontext)
        {
            db = dbcontext;
        }


    }
}
