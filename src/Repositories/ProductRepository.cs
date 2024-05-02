
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_backend_teamwork.src.Controllers
{
    public class ProductRepository : IProductRepository
    {
        private DbSet<Product> _products;//wheneve we want to use the product Entities, import the files uplines
        private DatabaseContext _databaseContext;

        public ProductRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
            _products = databaseContext.Products;//this is the database
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

        public IEnumerable<Product> findAll()
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
        //     throw new NotImplementedException();
        // }



    }
}