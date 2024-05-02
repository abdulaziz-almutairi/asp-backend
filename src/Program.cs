

using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using sda_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();// after the builder variable


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IProductService, ProductService>(); //this is the built-in DI container for the Service
builder.Services.AddScoped<IProductRepository, ProductRepository>(); //this is the built-in DI container for the Repository

// builder.Services.AddScoped<ICustomerOrderRepository, ICustomerOrderRepository>();




builder.Services.AddDbContext<DatabaseContext>(); // For the database context


var app = builder.Build();
app.MapControllers();// Should be added after the app variable



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();