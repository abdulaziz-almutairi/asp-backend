using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions

{
    public interface IProductRepository
    {

        public List<Product> findAll();
        // CustomerOrder GetOrderById(int orderId);
        public Product CreateOne(Product newProduct);

        public Product? DeleteProduct(Product deleeProduct);





        // public Product? findOne(string productId);



    }
}