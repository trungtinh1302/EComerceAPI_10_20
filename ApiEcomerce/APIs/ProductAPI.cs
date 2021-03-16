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

        //Get products by CatID
        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByCat([FromRoute] int CatID)
        {
            var productsGetByCatID = await db.Products.Where(x => x.ProductCategoryID == CatID).ToListAsync();
            if (productsGetByCatID == null)
            {
                return NotFound();
            }
            return Ok(productsGetByCatID);
        }

        //Get products by CatID with paging
        [HttpGet("[action]/{id}/{page}/{pagesize}")]
        public async Task<IActionResult> GetByCat([FromRoute] int CatID, int page, int pageSize)
        {
            int count = await db.Products.CountAsync();
            Response.Headers.Add("count", count.ToString());
            int skip = (page - 1) * pageSize;
            int take = pageSize;
            var productsGetByCatID = await db.Products
                                    .Where(x => x.ProductCategoryID == CatID)
                                    .OrderByDescending(x => x.CreateTime)
                                    .Skip(skip)
                                    .Take(take)
                                    .ToListAsync();

            if (productsGetByCatID == null)
            {
                return NotFound();
            }
            return Ok(productsGetByCatID);
        }

        [HttpGet("[action]/{id}")]
        public async Task<IActionResult> GetByMainCat([FromRoute] int CatID)
        {
            var productsGetByMainCat = await db.Products
                                    .Where(x => x.ProductCategories.ProductMainCategoryID == CatID)
                                    .ToListAsync();
            if (productsGetByMainCat == null)
            {
                return NotFound();
            }
            return Ok(productsGetByMainCat);
        }

        //Get products by MainCatID with paging
        [HttpGet("[action]/{id}/{page}/{pagesize}")]
        public async Task<IActionResult> GetByMainCat([FromRoute] int CatID, int page, int pageSize)
        {
            int count = await db.Products.CountAsync();
            Response.Headers.Add("count", count.ToString());
            int skip = (page - 1) * pageSize;
            int take = pageSize;
            var productsGetByMainCat = await db.Products
                                    .Where(x => x.ProductCategories.ProductMainCategoryID == CatID)
                                    .OrderByDescending(x => x.CreateTime)
                                    .Skip(skip)
                                    .Take(take)
                                    .ToListAsync();

            if (productsGetByMainCat == null)
            {
                return NotFound();
            }
            return Ok(productsGetByMainCat);
        }

        [HttpGet("[action]/{id}/{catid}/{take}")]
        public async Task<IActionResult> GetRelatedProducts([FromRoute] int ID, [FromRoute] int CatID, [FromRoute] int take)
        {
            var productsGetByMainCat = await db.Products
                                    .Where(x => x.ProductCategoryID == CatID && x.ProductID != ID)
                                    .OrderByDescending(x => x.CreateTime)
                                    .Take(take)
                                    .ToListAsync();

            if (productsGetByMainCat == null)
            {
                return NotFound();
            }
            return Ok(productsGetByMainCat);
        }

        //Gets Other Product
        [HttpGet("[action]/{take}")]
        public async Task<IActionResult> GetOther([FromRoute] int take)
        {
            var productsGetByMainCat = await db.Products
                                    .OrderBy(x => Guid.NewGuid())
                                    .Take(take)
                                    .ToListAsync();

            if (productsGetByMainCat == null)
            {
                return NotFound();
            }
            return Ok(productsGetByMainCat);
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
    }
}