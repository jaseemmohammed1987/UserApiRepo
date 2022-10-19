using Microsoft.EntityFrameworkCore;
using UserApi.Repository.Data;
using UserApi.Repository.Models;

namespace UserApi.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly UserApiContext _context;

        public UserRepository(UserApiContext context)
        {
            _context = context;
        }

        public async Task<User> GetUserAsync(int id)
        {
            var user = await _context.User.FindAsync(id);

            return user;
        }

        public async Task<User> PostUserAsync(User user)
        {
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }

        public async Task PutUserAsync(User user)
        {
            _context.Entry(user).State = EntityState.Modified;

            await _context.SaveChangesAsync();
        }
    }
}