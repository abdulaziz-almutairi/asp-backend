using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using Microsoft.EntityFrameworkCore;
namespace sda_onsite_2_csharp_backend_teamwork.src;


public class CustomerOrderRepository : ICustomerOrderRepository
{
    // private List<CustomerOrder> _orders;
    private DatabaseContext _databaseContext;
    private DbSet<CustomerOrder> _orders;

    public CustomerOrderRepository(DatabaseContext databaseContext)
    {
        _orders = databaseContext.CustomerOrders;
        _databaseContext = databaseContext;
    }
    // public CustomerOrderRepository()
    // {
    //     _orders = new List<CustomerOrder>();
    // }

    public IEnumerable<CustomerOrder> GetAllOrders()
    {
        return _orders;
    }

    public CustomerOrder GetOrderById(Guid orderId)
    {
        var getOrder = _orders.FirstOrDefault(order => order.UserId == orderId);
        if (getOrder != null)
        {
            return getOrder;
        }
        else
        {
            return null;
        }
    }

    public CustomerOrder CreateOrder(CustomerOrder order)
    {
        _orders.Add(order);
        _databaseContext.SaveChanges();
        return order;
    }


    public bool DeleteOrder(Guid orderId)
    {
        CustomerOrder? order = GetOrderById(orderId);
        if (order is null) return false;
        _orders.Remove(order);
        _databaseContext.SaveChanges();
        return true;
    }
}