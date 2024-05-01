using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;

namespace sda_onsite_2_csharp_backend_teamwork.src.services;
public interface IOrderItemService
{
    public List<OrderItem> GetOrderItems();
}
