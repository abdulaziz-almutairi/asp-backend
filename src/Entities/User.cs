namespace sda_onsite_2_csharp_backend_teamwork.src.Entities;


public class User
{
    public User(Guid id, string firstName, string lastName, string email, string password, int salt, string role)
    {
        Id = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
        Salt = salt;
        Role = role;
    }
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public int Salt { get; set; }
    public string Role { get; set; }
}
