using MediatorWepApi.Models;
using MediatorWepApi.Repository.Interfaces;

namespace MediatorWepApi.Repository
{
    public class UserRepository : IUserRepository
    {
        public Task<User> GetById(int id)
        {
            var user = new User()
            {
                Id = id,
                Email = "test@test.com",
                Phone = "1223243442",
                Username = "Matt"
            };

            return Task.FromResult(user);
        }

        public Task<User> Insert(User entity)
        {
            var user = new User()
            {
                Id = 2,
                Email = entity.Email,
                Phone = entity.Phone,
                Username = entity.Username
            };

            return Task.FromResult(user);
        }
    }
}
