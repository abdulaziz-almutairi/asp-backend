
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;


namespace sda_onsite_2_csharp_backend_teamwork;

public class CustomerOrderService
{
    private readonly ICustomerOrderRepository _repository;

    public CustomerOrderService(ICustomerOrderRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<CustomerOrder> GetAllOrders()
    {
        return _repository.GetAllOrders();
    }

    public CustomerOrder GetOrderById(int orderId)
    {
        return _repository.GetOrderById(orderId);
    }

    public void CreateOrder(CustomerOrder order)
    {
        _repository.CreateOrder(order);
    }
    public void DeleteOrder(int orderId)
    {
        _repository.DeleteOrder(orderId);
    }
}