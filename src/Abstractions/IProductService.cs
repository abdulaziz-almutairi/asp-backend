using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions


{
    public interface IProductService
    {
        public List<Product> findAll();
        public Product CreateOn(Product newProduct);

        public Product? DeleteProduct(string name);




    }
}