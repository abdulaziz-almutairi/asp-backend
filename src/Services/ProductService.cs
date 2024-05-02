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


        public Product CreateOne(Product newProduct)
        {
            return _productRepository.CreateOne(newProduct);
        }

        public Product? DeleteProduct(Guid productId)
        {
            Product? findProduct = _productRepository.findAll().FirstOrDefault(product => product.Id == productId);
            if (findProduct == null)
            {
                return null;
            }
            return _productRepository.DeleteProduct(findProduct);
        }

        public IEnumerable<Product> findAll()
        {
            return _productRepository.findAll();
        }


    }
}