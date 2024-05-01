
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions

{
    public interface IProductRepository
    {

        public List<Product> findAll();
        // CustomerOrder GetOrderById(int orderId);
        // public List<Product> CreateOne();




        // public Product? findOne(string productId);



    }
}