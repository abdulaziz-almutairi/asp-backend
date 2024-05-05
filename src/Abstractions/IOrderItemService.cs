using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Migrations;
using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.services;
public interface IOrderItemService
{
    public List<OrderItem> GetOrderItems();
    public OrderItem CreateOne(OrderItem newOrder);
    IEnumerable<Order> FindAll();
    ActionResult<Order?> FindOne(Guid orderId);
    ActionResult<OrderItem?> DeleteOne(Guid orderId);
}