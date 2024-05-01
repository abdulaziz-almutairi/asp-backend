using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;
public class DatabaseContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<CustomerOrder> CustomerOrder { get; set; }

    // public DatabaseContext()
    // {
    //     Products = [
    //     new Product("1", "iPhone 6s", DateTime.Now, 100, "Phone"),
    //     new Product("2", "iPhone X", DateTime.Now, 100, "Phone"),
    //     new Product("3", "iPhone GX", DateTime.Now, 100, "Phone")
    // ];
    //     users = [
    //     new User("1", "Faisal", "Mohammed", "faisal@faisal.com", "123456", 21, "Admin"),
    //     new User("2", "Sattam", "Ahmed", "Sattam@faisal.com", "112233", 18, "Costumer"),
    //     new User("3", "Abdulaziz", "Fathe", "Abdulaziz@faisal.com", "asdfgh", 03, "Costumer"),
    //     new User("4", "Turki", "Omar", "Turki@faisal.com", "password1", 72, "Costumer")
    // ];

    // }

    // private IConfiguration _config;
    // public DatabaseContext(IConfiguration config)
    // {
    //     _config = config;
    // }



    /*
    Please note that u nead to add ur own connection string in the Username and Password Only for example :
    @"Host=localhost;Username=Root;Password=Password;Datebase=ecommerce"
    */
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@"Host=localhost;Username=postgres;Password=Password;Datebase=ecommerce");

}


