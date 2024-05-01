

namespace sda_onsite_2_csharp_backend_teamwork.src.DataBases
{
    public class DatabaseContext
    {

        public List<OrderItem> OrderItems { get; }

        public DatabaseContext()
        {
            OrderItems = [
            new OrderItem("1", "123", 100),
            new OrderItem("1", "4", 100),
        ];
        }
    }
}
