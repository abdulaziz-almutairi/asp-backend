using Microsoft.AspNetCore.Mvc;


namespace sda_onsite_2_csharp_backend_teamwork;


public class CustomerOrder
{
    public Guid Id { get; } = Guid.NewGuid();
    public int UserId { get; set; }

    public DateTime Date { get; set; }
    public string Status { get; set; }
    public string Address { get; set; }


}