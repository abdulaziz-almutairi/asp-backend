
using Microsoft.AspNetCore.Mvc;
using sda_backend_teamwork.src.Abstractions;
using sda_backend_teamwork.src.Database;
using sda_backend_teamwork.src.Entities;

namespace sda_backend_teamwork.src.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {

        private IProductService _productService; //this to inject the service methods into the controller

        public ProductController(IProductService productService) // this is the constructor dependency injection
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> findAll()
        {

            return _productService.findAll(); // this to run the method to get all the products
        }

        // [HttpGet("{productId}")] //Build endpoint for single entity
        // public Product findOne(string productId)
        // {

        //     Console.WriteLine($"This is the id: {productId}");
        //    ;
        // }



        // [HttpPost] //to use this method, import AspNetCore
        // public List<Product> CreateOne([FromBody] Product product) //this is the body example to send data
        // {
        //     _products.Add(product);
        //     return _products;
        // }
    }
}