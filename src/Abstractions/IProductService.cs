using sda_backend_teamwork.src.Entities;

namespace sda_backend_teamwork.src.Abstractions
{
    public interface IProductService
    {
        public List<Product> findAll();
        // public List<Product> findOne();

    }
}