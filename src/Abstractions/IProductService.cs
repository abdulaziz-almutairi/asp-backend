using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions


{
    public interface IProductService
    {
        public IEnumerable<Product> FindAll();
        public Product CreateOne(Product newProduct);

        public Product? DeleteProduct(Guid produtId);




    }
}