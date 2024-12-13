using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moviey_Back.Interfaces;
using Moviey_Back.Models;
using Moviey_Back.Repositories;

namespace Moviey_Back.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public IProductRepo ProductRepo { get; }
        
        public ProductController(IProductRepo _ProductRepo)
        {
            ProductRepo = _ProductRepo;
        }


        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Product> products = ProductRepo.GetAll();
            return Ok(products);
        }

        [HttpGet("id")]
        public IActionResult GetProduct(int id) { 
            Product product = ProductRepo.GetById(id);
            if (product == null) {
                return BadRequest("there is no products");
            }
            return Ok(product);
        }

        [HttpGet("GetProductsByType")]
        public IActionResult GetProductsByType(string str)
        {
            List<Product> products = ProductRepo.GetProductsByType(str);
            
            if (products == null)
            {
                return BadRequest("there is no products");
            }
            return Ok(products);
        }

        

        [HttpPost]
        public IActionResult AddProduct(Product product) { 
           ProductRepo.Add(product);
            ProductRepo.Save();
            return Ok(product);
        }


    }
}
