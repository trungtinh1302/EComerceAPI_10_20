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
    [Route("api/accountcat")]
    [ApiController]
    public class AccountCategoryAPI : Controller
    {
        private DBContext db;
        public AccountCategoryAPI(DBContext dbContext)
        {
            db = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Gets()
        {
            var accountCat = await db.AccountCategories.ToListAsync();
            if (accountCat != null)
            {
                return Ok(accountCat);
            }

            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int ID)
        {
            var data = await db.AccountCategories.FirstOrDefaultAsync(x => x.AccountCategoryID == ID);
            if (data != null)
            {
                return Ok(data);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int ID, [FromBody] AccountCategory accountCategory)
        {
            if (accountCategory.AccountCategoryID != ID)
                return BadRequest();

            if (!await db.AccountCategories.AnyAsync(x => x.AccountCategoryID == ID))
                return NotFound();

            db.Entry(accountCategory).State = EntityState.Modified;
            try
            {
                await db.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return Forbid();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] AccountCategory accountCategory)
        {
            db.Entry(accountCategory).State = EntityState.Added;
            try
            {
                await db.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return Forbid();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int ID)
        {
            var accountCat = await db.AccountCategories.FirstOrDefaultAsync(x => x.AccountCategoryID == ID);
            if (accountCat == null)
                return NotFound();

            db.AccountCategories.Remove(accountCat);
            try
            {
                await db.SaveChangesAsync();
                return Ok();
            }
            catch
            {
                return Forbid();
            }
        }
    }
}
