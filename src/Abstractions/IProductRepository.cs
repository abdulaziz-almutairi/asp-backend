using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions

{
    public interface IProductRepository
    {

        public IEnumerable<Product> FindAll(int limit, int page);
        // CustomerOrder GetOrderById(int orderId);
        public Product CreateOne(Product newProduct);

        public Product? DeleteProduct(Product deleeProduct);

        public Product? FindOne(Guid id);



        // public Product? findOne(string productId);



    }
}