using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.DTOs
{
    public class CustomerOrderReadDto
    {
        public Guid Id { get; set; }
        public string? Status { get; set; }
        public DateTime Date { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { set; get; }

    }
    public class CustomerOrderCreateDto
    {
        public string Address { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { set; get; }
    }

}