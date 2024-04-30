

using Microsoft.AspNetCore.Mvc;
using sda_backend_teamwork.src.Entities;

namespace sda_backend_teamwork.src.Database

{
    public class DatabaseContext
    {
        public List<Product> products;

        public DatabaseContext()
        {
            products = [
            new Product("1", "iPhone 6s", DateTime.Now, 100, "Phone"),
            new Product("2", "iPhone X", DateTime.Now, 100, "Phone"),
            new Product("3", "iPhone GX", DateTime.Now, 100, "Phone")
        ];

        }


    }
}