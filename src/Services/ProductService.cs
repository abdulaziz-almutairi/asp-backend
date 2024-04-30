using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> findAll()
        {
            return _productRepository.findAll();
        }






    }
}