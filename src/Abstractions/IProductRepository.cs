
using sda_backend_teamwork.src.Entities;

namespace sda_backend_teamwork.src.Abstractions
{
    public interface IProductRepository
    {

        public List<Product> findAll();


        public Product? findOne(string productId);



    }
}