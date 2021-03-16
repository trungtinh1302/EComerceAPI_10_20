using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcomerce.APIs
{
    [Produces("application/json")]
    [Route("api/account")]
    [ApiController]
    public class AccountAPI : Controller
    {
        private DBContext db;
        public AccountAPI(DBContext dbContext)
        {
            db = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Gets()
        {
            var account = await db.Accounts.ToListAsync();
            if (account != null)
            {
                return Ok(account);
            }

            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int ID)
        {
            var data = await db.Accounts.FirstOrDefaultAsync(x => x.AccountID == ID);
            if (data != null)
            {
                return Ok(data);
            }

            return NotFound();
        }

        [HttpGet("{page}/{pagesize}")]
        public async Task<IActionResult> Get(int page, int pageSize)
        {
            int count = await db.Accounts.CountAsync();
            Response.Headers.Add("count", count.ToString());
            int skip = (page = 1) * pageSize;
            int take = pageSize;

            var account = await db.Accounts.OrderByDescending(x => x.CreateTime)
                                           .Skip(skip)
                                           .Take(take)
                                           .ToListAsync();
            if (account != null)
                return Ok(account);
            else
                return NotFound();
        }

    }
}
