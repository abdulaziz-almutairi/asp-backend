using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using AutoMapper;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers
{
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;

        private IProductRepository _categoryRepository;
        private IMapper _mapper;



        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }


        public Product CreateOne(ProductCreateDto newProduct)
        {
            // Category? mappedCategory = _mapper.Map<Category>(category);

            Product? mappedProduct = _mapper.Map<Product>(newProduct);
            return _productRepository.CreateOne(mappedProduct);
        }

        public IEnumerable<Product> FindAll(int limit, int page)
        {

            return _productRepository.FindAll(limit, page);
        }

        public Product? DeleteProduct(Guid productId)
        {
            Product? findProduct = _productRepository.FindOne(productId);
            if (findProduct == null)
            {
                return null;
            }
            return _productRepository.DeleteProduct(findProduct);

        }




        public ProductReadDto? FindOne(Guid id)
        {
            Product? product = _productRepository.FindOne(id);

            if (product is null)
            {
                return null;
            }

            return _mapper.Map<ProductReadDto>(product);
        }


    }
}