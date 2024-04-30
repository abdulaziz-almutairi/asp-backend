

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities
{
    public class Product
    {
        public string Id { get; set; }



        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public int Price { get; set; }

        public string Category { get; set; }


        public Product(string id, string name, DateTime createdAt, int price, string category)
        {
            Id = id;
            Name = name;
            CreatedAt = createdAt;
            Price = price;
            Category = category;
        }

    }
}