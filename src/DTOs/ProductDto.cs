

namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class ProductCreateDto
    {


        public string Name { get; set; }

        public int Price { get; set; }


        public Guid CategoryId { get; set; }
    }
}