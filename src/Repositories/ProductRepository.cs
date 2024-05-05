
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;



namespace sda_backend_teamwork.src.Controllers
{
    public class ProductRepository : IProductRepository
    {

        private DatabaseContext _databaseContext;
        private DbSet<Product> _products;//wheneve we want to use the product Entities, import the files uplines

        public ProductRepository(DatabaseContext databaseContext)
        {
            _products = databaseContext.Products;//wheneve we want to use the product Entities, import the files uplines
            _databaseContext = databaseContext;
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

        public IEnumerable<Product> FindAll()
        {
            return _products.ToList();
        }


    }
}