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
    [Route("api/productmaincat")]
    [ApiController]
    public class ProductMainCategoryAPI : Controller
    {
        private DBContext db;
        public ProductMainCategoryAPI(DBContext dBContext)
        {
            db = dBContext;
        }

        [HttpGet]
        public async Task<IActionResult> Gets()
        {
            var mainCatProducts = await db.ProductMainCategories.ToListAsync();
            if (mainCatProducts != null)
                return Ok(mainCatProducts);
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] int ID)
        {
            var productMainCat = await db.ProductMainCategories.FirstOrDefaultAsync(x => x.ProductMainCategoryID == ID);
            if (productMainCat == null)
                return NotFound();

            return Ok(productMainCat);
        }

        [HttpGet("{page}/{pagesize}")]
        public async Task<IActionResult> Get(int page, int pageSize)
        {
            int count = await db.ProductMainCategories.CountAsync();
            Response.Headers.Add("count", count.ToString());
            int skip = (page - 1) * pageSize;
            int take = pageSize;

            var productMainCat = await db.ProductMainCategories
                                       .OrderByDescending(x => x.CreateTime)
                                       .Skip(skip)
                                       .Take(take)
                                       .ToListAsync();

            if (productMainCat != null)
                return Ok(productMainCat);
            else
                return NotFound();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromRoute] int ID, [FromBody] ProductMainCategory productMainCategory)
        {
            if (productMainCategory.ProductMainCategoryID != ID)
                return BadRequest();

            if (!await db.ProductMainCategories.AnyAsync(x => x.ProductMainCategoryID == ID))
                return NotFound();

            db.Entry(productMainCategory).State = EntityState.Modified;
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
        public async Task<IActionResult> Create([FromBody] ProductMainCategory productMainCategory)
        {
            db.Entry(productMainCategory).State = EntityState.Added;

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
            var productMainCat = await db.ProductMainCategories.FirstOrDefaultAsync(x => x.ProductMainCategoryID == ID);
            if (productMainCat == null)
                return NotFound();

            db.ProductMainCategories.Remove(productMainCat);
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
