using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;


namespace sda_onsite_2_csharp_backend_teamwork;


public class CustomerOrderController : CostumeController
{
    private readonly ICustomerOrederService _orderService;

    public CustomerOrderController(ICustomerOrederService orderService)
    {
        _orderService = orderService;
    }

    [HttpGet]
    public IActionResult GetAllOrders()
    {
        var orders = _orderService.GetAllOrders();
        return Ok(orders);
    }

    [HttpGet("{id}")]
    public IActionResult GetOrderById(Guid id)
    {
        var order = _orderService.GetOrderById(id);
        if (order == null)
        {
            return NotFound();
        }

        return Ok(order);
    }

    [HttpPost]
    public IActionResult CreateOrder(CustomerOrder order)
    {
        _orderService.CreateOrder(order);
        return CreatedAtAction(nameof(GetOrderById), new { id = order.Id }, order);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteOrder(Guid id)
    {
        _orderService.DeleteOrder(id);
        return NoContent();
    }
}

