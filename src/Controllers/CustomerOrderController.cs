using Microsoft.AspNetCore.Mvc;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using AutoMapper;



namespace sda_onsite_2_csharp_backend_teamwork.src.Controllers;


public class CustomerOrderController : CostumeController
{
    private readonly ICustomerOrderService _orderService;
    private readonly IMapper _mapper;


    public CustomerOrderController(ICustomerOrderService orderService, IMapper mapper)
    {
        _mapper = mapper;
        _orderService = orderService;
    }

    [HttpGet]
    public ActionResult<IEnumerable<CustomerOrderReadDto>> GetAllOrders()
    {
        return Ok(_orderService.GetAllOrders());
    }

    [HttpGet("{id}")]
    public ActionResult<CustomerOrderReadDto?> GetOrderById(Guid id)
    {
        var order = _orderService.GetOrderById(id);
        if (order == null)
        {
            return NotFound();
        }

        return Ok(order);
    }

    [HttpDelete("delete/{id}")]
    public ActionResult DeleteOrder(Guid id)
    {
        _orderService.DeleteOrder(id);
        return NoContent();
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public ActionResult<CustomerOrderReadDto> CreateOne(CustomerOrderReadDto order)
    {
        if (order is not null)
        {
            var orderToCreate = _mapper.Map<CustomerOrderCreateDto>(order);
            var createdOrderItem = _orderService.CreateOrder(orderToCreate);
            var createdOrder = _mapper.Map<CustomerOrderReadDto>(createdOrderItem);
            return CreatedAtAction(nameof(GetOrderById), new { id = createdOrder.Id }, createdOrder);
        }
        return BadRequest();
    }
}

