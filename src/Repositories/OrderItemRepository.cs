using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sda_onsite_2_csharp_backend_teamwork.src.DataBases;
namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

[Route("[controller]")]
public class OrderItemRepository : IOrderItemRepository
{
    private DatabaseContext _databaseContext;
    private List<OrderItem> _orderItems;
    public OrderItemRepository(DatabaseContext databaseContext)
    {
        _databaseContext = databaseContext;
    }

    public IEnumerable<OrderItem> GetAll()
    {
        return _databaseContext.OrderItems;
    }
    public OrderItem GetOrderById(Guid orderId)
    {
        return _databaseContext.GetOrderById(orderId);
    }


}
