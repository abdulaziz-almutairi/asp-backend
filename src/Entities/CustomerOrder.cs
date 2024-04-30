using Microsoft.AspNetCore.Mvc;


namespace sda_onsite_2_csharp_backend_teamwork;


public class CustomerOrder
{
    public Guid id { get; } = Guid.NewGuid();
    public int userId { get; set; }

    public DateTime date { get; set; }
    public string status { get; set; }
    public string address { get; set; }


}