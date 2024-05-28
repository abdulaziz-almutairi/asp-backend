
namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public interface ICustomerOrderRepository
{
    IEnumerable<CustomerOrder> GetAllOrders();
    CustomerOrder GetOrderById(Guid orderId);
    public CustomerOrder CreateOrder(CustomerOrder order);
    public bool DeleteOrder(Guid orderId);
}