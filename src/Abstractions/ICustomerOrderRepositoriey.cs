
namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories;

public interface ICustomerOrderRepository
{
    IEnumerable<CustomerOrder> GetAllOrders();
    CustomerOrder GetOrderById(int orderId);
    void CreateOrder(CustomerOrder order);
    void DeleteOrder(int orderId);
}