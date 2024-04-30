using Microsoft.AspNetCore.Mvc;

using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases

{
    public class DatabaseContext
    {
        public List<Product> Products { get; }

        public DatabaseContext()
        {
            Products = [
            new Product("1", "iPhone 6s", DateTime.Now, 100, "Phone"),
            new Product("2", "iPhone X", DateTime.Now, 100, "Phone"),
            new Product("3", "iPhone GX", DateTime.Now, 100, "Phone")
        ];

        }


    }
}