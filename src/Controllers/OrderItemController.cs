using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.services;
using sda_onsite_2_csharp_backend_teamwork.src.Services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers;
public class OrderItemsController : BaseController
{
    private readonly IOrderItemService _orderItemService;

    public OrderItemsController(IOrderItemService orderItemService)
    {
        _orderItemService = orderItemService;
    }

    [HttpGet]
    public ActionResult<List<OrderItem>> GetOrderItems()
    {
        var orderItems = _orderItemService.GetOrderItems();
        return Ok(orderItems);
    }
    [HttpPost]
    public OrderItem CreateOne([FromBody] OrderItem order)
    {
        return _orderItemService.CreateOne(order);
    }
}
