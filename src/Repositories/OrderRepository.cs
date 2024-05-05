using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class OrderRepository : IOrderRepository

    {

        private DbSet<OrderItem> _orderItems;
        private DatabaseContext _DbSet;

        public OrderRepository(DatabaseContext databaseContext)
        {
            _orderItems = databaseContext.OrderItems;
            _DbSet = databaseContext;
        }

        public IEnumerable<OrderItem> FindAll()
        {
            return _orderItems;
        }

        public OrderItem? FindOne(Guid OrderId)
        {
            var findOrder = _orderItems.FirstOrDefault((order) => order.Id == OrderId);
            return findOrder;

        }

        public OrderItem CreateOne(OrderItem newOrder)
        {
            _orderItems.Add(newOrder);
            _DbSet.SaveChanges();

            return newOrder;
        }

        public OrderItem? DeleteOne(Guid orderId)
        {
            var deleteOrder = FindOne(orderId);
            _orderItems.Remove(deleteOrder!);
            _DbSet.SaveChanges();

            return DeleteOne(orderId);
        }

        IEnumerable<Order> IOrderRepository.FindAll()
        {
            throw new NotImplementedException();
        }

        Order? IOrderRepository.FindOne(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public Order CreateOne(Order order)
        {
            throw new NotImplementedException();
        }

        Order? IOrderRepository.DeleteOne(Guid orderId)
        {
            throw new NotImplementedException();
        }
    }
}