using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using uppg4WebApiJOchSON.Models;

namespace uppg4WebApiJOchSON.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private NorthwindContext _context;

        public ProductController(NorthwindContext context)
        {
            _context = context;
        }

        //[HttpGet("{productId}")]
        //public ActionResult<Products> Get(int productId)
        //{
        //    return GetProduct(productId);
        //}

        [HttpGet("{productName}/{unitPrice}")]
        public ActionResult<List<Products>> Get(string productName, decimal unitPrice)
        {
            return GetProductList(productName, unitPrice);
        }

        private IEnumerable<Products> GetAllProductsDb()
        {
            IEnumerable<Products> allProductsDb = _context.Products;

            return allProductsDb;
        }

        private List<Products> GetProductList(string productName, decimal unitPrice)
        {
            IEnumerable<Products> allProductsDb = GetAllProductsDb();

            List<Products> selectedProducts = allProductsDb.Where(p => p.ProductName.Contains(productName)).ToList();
            List<Products> selectedProductsPrice = selectedProducts.Where(p => p.UnitPrice > unitPrice).ToList();

            return selectedProductsPrice;
        }


        private Products GetProduct(int productId)
        {
            IEnumerable<Products> allProductsDb = GetAllProductsDb();

            Products currentProductDb = allProductsDb.SingleOrDefault(p => p.ProductId == productId);

            return currentProductDb;
        }
    }
}