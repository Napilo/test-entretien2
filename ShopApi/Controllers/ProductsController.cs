using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ShopApi.Models;

namespace ShopApi.Controllers
{
    [ApiController]    
    public class ProductsController : ControllerBase
    {
        private ShopDBContext dbContext { get; set; }

        public ProductsController(ShopDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet("Products")]
        public async Task<ActionResult> GetProducts()
        {
            try
            {
                IEnumerable<Product> products = await dbContext.Product.ToListAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("Product")]
        public async Task<ActionResult> GetOneProduct(int productId)
        {
            try
            {
                //Product product = await dbContext.Product.Where(t=> t.Id == productId).FirstOrDefaultAsync();
                Product product = await dbContext.Product.FindAsync(productId);

                if (product == null)
                {
                    return NotFound();
                }

                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
