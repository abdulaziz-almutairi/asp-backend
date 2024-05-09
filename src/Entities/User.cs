using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Enums;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;


[Index(nameof(Email), IsUnique = true)]
public class User
{
    private Random rnd = new Random(); // generate salt
    public User(Guid id, string firstName, string lastName, string email, string password, Role role)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        Salt = rnd.Next(10, 100);
        Role = role;
    }

    public Guid Id { get; set; }
    [Required]
    public string FirstName { get; set; }
    public string LastName { get; set; }
    [Required, EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Password { get; set; }
    public int Salt { get; set; }
    public Role Role { get; set; } = Role.Customer;
    public IEnumerable<Order>? Order { get; set; }
}
