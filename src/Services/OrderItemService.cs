using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.services;

namespace sda_onsite_2_csharp_backend_teamwork.src.Services;
public class OrderItemService : IOrderItemService
{
    private readonly IOrderItemRepository _orderItemRepository;

    public OrderItemService(IOrderItemRepository orderItemRepository)
    {
        _orderItemRepository = orderItemRepository;
    }

    public List<OrderItem> GetOrderItems()
    {
        return _orderItemRepository.GetAll().ToList();
    }

    public OrderItem GetOrderById(Guid orderId)
    {
        return _orderItemRepository.GetOrderById(orderId);
    }
    public OrderItem CreateOne(OrderItem newOrder)
    {
        return _orderItemRepository.CreateOne(newOrder);
    }

}
