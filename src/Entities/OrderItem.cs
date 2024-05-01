using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src;
public class OrderItem
{
    public OrderItem(string orderId, string productId, int quantity)
    {
        OrderId = orderId;
        ProductId = productId;
        Quantity = quantity;
    }

    public Guid Id { get; set; } = Guid.NewGuid();
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public int Quantity { get; set; }

}
