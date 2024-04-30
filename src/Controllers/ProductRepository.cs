
using sda_backend_teamwork.src.Abstractions;
using sda_backend_teamwork.src.Database;
using sda_onsite_2_csharp_backend_teamwork.Entities;

namespace sda_backend_teamwork.src.Controllers
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products;//wheneve we want to use the product Entities, import the files uplines

        public ProductRepository()
        {
            _products = new DatabaseContext().products;//wheneve we want to use the product Entities, import the files uplines
        }

        public List<Product> findAll()
        {
            return _products;
        }


    }
}