using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;


namespace sda_onsite_2_csharp_backend_teamwork;

[ApiController]
[Route("api/[controller]")]
public class CustomerOrderController : ControllerBase
{
    private readonly CustomerOrderService _orderService;

    public CustomerOrderController(CustomerOrderService orderService)
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
    public IActionResult GetOrderById(int id)
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
        return CreatedAtAction(nameof(GetOrderById), new { id = order.id }, order);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteOrder(int id)
    {
        _orderService.DeleteOrder(id);
        return NoContent();
    }
}

