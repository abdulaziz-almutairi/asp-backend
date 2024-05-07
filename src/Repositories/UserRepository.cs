using Microsoft.EntityFrameworkCore;
using sda_onsite_2_csharp_backend_teamwork.src.Abstractions;
using sda_onsite_2_csharp_backend_teamwork.src.Databases;
using sda_onsite_2_csharp_backend_teamwork.src.Entities;

namespace sda_onsite_2_csharp_backend_teamwork.src.Repositories
{
    public class UserRepository : IUserRepository
    {
        private DbSet<User> _users;
        public UserRepository(DatabaseContext databaseContext)
        {
            _users = databaseContext.Users;
        }

        public IEnumerable<User> FindAll()
        {
            return _users;
        }

        public User CreateOne(User user)
        {
            _users.Add(user);
            return user;
        }
        public User? FindOneByEmail(string email)
        {
            User? user = _users.FirstOrDefault(user => user.Email == email);
            return user;
        }

        public User UpdateOne(User updatedUser)
        {
            // var users = _users.Select(user =>
            //  {
            //      if (user.Email == updatedUser.Email)
            //      {
            //          return updatedUser;
            //      }
            //      return user;
            //  });
            // _users = users;

            return updatedUser;
        }
    }

}