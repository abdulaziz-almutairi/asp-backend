
using AutoMapper;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.DTOs;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;


namespace sda_onsite_2_csharp_backend_teamwork;

public class CustomerOrderService : ICustomerOrderService
{
    private readonly ICustomerOrderRepository _repository;
    private readonly IMapper _mapper;


    public CustomerOrderService(ICustomerOrderRepository repository, IMapper mapper)
    {
        _mapper = mapper;
        _repository = repository;
    }

    public IEnumerable<CustomerOrderReadDto> GetAllOrders()
    {
        var orders = _repository.GetAllOrders();
        var ordersRead = orders.Select(_mapper.Map<CustomerOrderReadDto>);
        return ordersRead;
    }

    public CustomerOrderReadDto? GetOrderById(Guid orderId)
    {
        CustomerOrder? order = _repository.GetOrderById(orderId);
        CustomerOrderReadDto? orderRead = _mapper.Map<CustomerOrderReadDto>(order);
        return orderRead;
    }

    public CustomerOrderReadDto CreateOrder(CustomerOrderCreateDto order)
    {
        var orderEntity = _mapper.Map<CustomerOrder>(order);
        if (orderEntity != null)
        {
            var createdOrder = _repository.CreateOrder(orderEntity);
            return _mapper.Map<CustomerOrderReadDto>(createdOrder);
        }
        else
        {
            throw new Exception("Failed to create order.");
        }
    }
    public bool DeleteOrder(Guid orderId)
    {
        return _repository.DeleteOrder(orderId);
    }
}