

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Product
    {
        public Guid Id { get; set; }



        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Price { get; set; }

        public Category Category { get; set; }
        public Guid CategoryId { get; set; }

        public Product(string name, DateTime createdAt, int price, Guid categoryId)
        {
            Name = name;
            CreatedAt = createdAt;
            Price = price;
            CategoryId = categoryId;
        }

    }
}