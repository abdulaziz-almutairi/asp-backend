
using sda_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;
using sda_onsite_2_csharp_backend_teamwork.src.services;
using sda_onsite_2_csharp_backend_teamwork.src.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();// after the builder variable


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


builder.Services.AddScoped<IUserService, UserService>(); //this is the built-in DI container for the Service
builder.Services.AddScoped<IUserRepository, UserRepository>(); //this is the built-in DI container for the Repository

builder.Services.AddScoped<IProductService, ProductService>(); //this is the built-in DI container for the Service
builder.Services.AddScoped<IProductRepository, ProductRepository>(); //this is the built-in DI container for the Repository

builder.Services.AddScoped<IOrderItemService, OrderItemService>(); //this is the built-in DI container for the Service
builder.Services.AddScoped<IOrderItemRepository, OrderItemRepository>(); //this is the built-in DI container for the Repository



builder.Services.AddScoped<ICustomerOrederService, CustomerOrderService>();
builder.Services.AddScoped<ICustomerOrderRepository, CustomerOrderRepository>();




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