using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src;
public class OrderItem
{

    public Guid Id { get; set; }
    public string OrderId { get; set; }
    public string ProductId { get; set; }
    public int Quantity { get; set; }

}
