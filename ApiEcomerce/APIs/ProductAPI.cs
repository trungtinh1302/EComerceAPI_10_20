using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Model;

namespace ApiEcomerce.API
{
    [Produces("application/json")]
    [Route("api/product")]
    [ApiController]
    public class ProductAPI : Controller
    {
        private DBContext db;
        public ProductAPI(DBContext dbContext)
        {
            db = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Gets()
        {
            var products = await db.Products.ToListAsync();
            if (products != null)
            {
                return Ok(products);
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int ID)
        {
            var product = await db.Products.FirstOrDefaultAsync(x => x.ProductID == ID);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        //Get products paging
        [HttpGet("{page}/{pagesize}")]
        public async Task<IActionResult> Get(int page, int pageSize)
        {
            int count = await db.Products.CountAsync();

            Response.Headers.Add("count", count.ToString());

            int skip = (page - 1) * pageSize;
            int take = pageSize;

            var products = await db.Products
                                .OrderByDescending(x => x.CreateTime)
                                .Skip(skip)
                                .Take(take)
                                .ToListAsync();

            if (products != null)
                return Ok(products);
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int ID, [FromBody] Product product)
        {
            if (product.ProductID != ID)
                return BadRequest();

            if (!await db.Products.AnyAsync(x => x.ProductID == ID))
                return NotFound();

            db.Entry(product).State = EntityState.Modified;

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
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            db.Entry(product).State = EntityState.Added;
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
            var product = await db.Products.FirstOrDefaultAsync(x => x.ProductID == ID);
            if (product == null)
                return NotFound();

            db.Products.Remove(product);
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

        //Get products by CatID
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByCat(int ID)
        {

            return Ok();
        }
    }
}
