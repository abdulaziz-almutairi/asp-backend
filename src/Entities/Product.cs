

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

        public Product(Guid id, string name, DateTime createdAt, int price, string category)
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
            Price = price;
            Category = category;
        }

    }
}