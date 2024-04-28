using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;

public class User
{
    public User(string id, string first_name, string last_name, string email, string password, int salt, string role)
    {
        Id = id;
        FirstName = first_name;
        LastName = last_name;
        Email = email;
        Password = password;
        Salt = salt;
        Role = role;
    }
    public string Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Salt { get; set; }
    public string Role { get; set; }
}
