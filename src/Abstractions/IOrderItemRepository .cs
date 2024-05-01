
using sda_onsite_2_csharp_backend_teamwork.src;
using sda_onsite_2_csharp_backend_teamwork.src.Controllers;
using sda_onsite_2_csharp_backend_teamwork.src.Repositories;
public interface IOrderItemRepository
{
    public IEnumerable<OrderItem> GetAll();
    public OrderItem? GetOrderById(Guid orderId);

}
