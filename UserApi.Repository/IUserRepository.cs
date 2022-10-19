using UserApi.Repository.Models;

namespace UserApi.Repository
{
    public interface IUserRepository
    {
        public Task<User> GetUserAsync(int id);

        public Task PutUserAsync(User user);

        public Task<User> PostUserAsync(User user);
    }
}
