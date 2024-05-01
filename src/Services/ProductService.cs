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

        public Product CreateOn(Product newProduct)//implemtnt the interace (IProductService)
        {
            return _productRepository.CreateOne(newProduct);//this is how we talk to the Repository
        }

        public Product? DeleteProduct(string name)
        {
            var findProduct = _productRepository.findAll().FirstOrDefault(product => product.Name == name);
            if (findProduct == null){
                return null;
            }
            return _productRepository.DeleteProduct(name);
        }

        public List<Product> findAll()
        {
            return _productRepository.findAll();
        }


    }
}