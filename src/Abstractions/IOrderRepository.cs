

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions
{
    public interface IOrderRepository
    {
        public IEnumerable<OrderItem> FindAll();
        public OrderItem? FindOne(Guid orderId);
        public OrderItem CreateOne(OrderItem newOrder);
        public bool DeleteOne(Guid orderId);


    }
}