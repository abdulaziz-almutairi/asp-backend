using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;
using sda_backend_teamwork.src.Database;
namespace sda_onsite_2_csharp_backend_teamwork;


public class CustomerOrderRepository : ICustomerOrderRepository
{
    private List<CustomerOrder> _orders;

    public CustomerOrderRepository()
    {
        _orders = new List<CustomerOrder>();
    }

    public IEnumerable<CustomerOrder> GetAllOrders()
    {
        return _orders;
    }

    public CustomerOrder GetOrderById(int orderId)
    {
        return _orders.FirstOrDefault(order => order.userId == orderId);
    }

    public void CreateOrder(CustomerOrder order)
    {
        _orders.Add(order);
    }


    public void DeleteOrder(int orderId)
    {
        var existingOrder = GetOrderById(orderId);
        if (existingOrder != null)
        {
            _orders.Remove(existingOrder);
        }
    }
}