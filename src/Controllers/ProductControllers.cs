
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers

{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService; //this to inject the service methods into the controller

        public ProductController(IProductService productService) // this is the constructor dependency injection
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> findAll()
        {

            return _productService.findAll(); // this to run the method to get all the products
        }





        [HttpPost] //to use this method, import AspNetCore
        public Product CreateOne([FromBody] Product product) //this is the body example to send data
        {
            return _productService.CreateOne(product);//this is how we talk to service
        }

        [HttpDelete("{name}")]
        public Product? DeleteProduct(string name)
        {
            return _productService.DeleteProduct(name);
        }


    }
}