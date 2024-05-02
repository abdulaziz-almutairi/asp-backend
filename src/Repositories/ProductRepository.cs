
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_backend_teamwork.src.Controllers
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;//wheneve we want to use the product Entities, import the files uplines

        public ProductRepository()
        {
            _products = new DatabaseContext().Products;//this is the database 
        }

        public Product CreateOne(Product newProduct)
        {
            _products.Add(newProduct);
            return newProduct;
        }

        public Product? DeleteProduct(Product deleeProduct)
        {
            _products.Remove(deleeProduct);
            return deleeProduct;
        }

        public List<Product> findAll()
        {
            return _products;
        }

        // public Product GetProduct(string productId)
        // {
        //     return _products;
        // }



        // [HttpGet("{productId}")] //Build endpoint for single entity
        // public Product FindOne(string productId)
        // {

        //     Console.WriteLine($"This is the id: {productId}");

        // }



        // [HttpPost("{CreateProducts}")] //Build endpoint for single entity
        // public ActionResult<List<Product>> CreateOne([FromBody] Product product)
        // {
        //     _products.Add(product);
        //     return _products;

        // }

    }
}