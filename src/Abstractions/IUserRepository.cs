using sda_onsite_2_csharp_backend_teamwork.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.Abstractions
{
    public interface IUserRepository
    {
        public List<User> FindAll();
        public User CreateOne(User user);
        public User? FindOneByEmail(string email);
        public User UpdateOne(User updatedUser);
    }
}