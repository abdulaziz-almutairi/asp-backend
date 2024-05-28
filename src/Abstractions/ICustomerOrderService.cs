using sda_onsite_2_csharp_backend_teamwork.src.DTOs;


namespace sda_onsite_2_csharp_backend_teamwork.src.Abstractions;

public interface ICustomerOrderService
{
    public IEnumerable<CustomerOrderReadDto> GetAllOrders();
    public CustomerOrderReadDto GetOrderById(Guid orderId);
    public CustomerOrderReadDto CreateOrder(CustomerOrderCreateDto orderDto);
    public bool DeleteOrder(Guid orderId);
}
