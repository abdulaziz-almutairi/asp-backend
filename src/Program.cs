// using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;
using sda_onsite_2_csharp_backend_teamwork.src.Services;
using sda_backend_teamwork.src.Abstractions;
using sda_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();// after the builder variable


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


// builder.Services.AddScoped<IProductService, ProductService>(); //this is the built-in DI container for the Service
// builder.Services.AddScoped<IProductRepository, ProductRepository>(); //this is the built-in DI container for the Repository

// builder.Services.AddScoped<ICustomerOrderRepository, CustomerOrderRepository>();
builder.Services.AddScoped<ICustomerOrderRepository, ICustomerOrderRepository>();


var app = builder.Build();
app.MapControllers();// Should be added after the app variable



app.MapControllers();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();