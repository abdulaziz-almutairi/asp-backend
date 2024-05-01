
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
            _products = new DatabaseContext().Products;//wheneve we want to use the product Entities, import the files uplines
        }

        public List<Product> findAll()
        {
            return _products;
        }

        // public Product? findOne(string productId)
        // {
        //     throw new NotImplementedException();
        // }



    }
}