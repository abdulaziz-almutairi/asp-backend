using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Databases;
public class DatabaseContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<CustomerOrder> CustomerOrder { get; set; }


    private IConfiguration _config;
    public DatabaseContext(IConfiguration config)
    {
        _config = config;
    }



    /*
    Please Note u need to cheange the Pgadmin Password on appsettings.json file 
    */
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(@$"Host={_config["Db:Host"]};Username={_config["Db:Username"]};Password={_config["Db:Password"]};Datebase={_config["Db:Database"]}")
        .UseSnakeCaseNamingConvention();

}




