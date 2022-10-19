using Microsoft.EntityFrameworkCore;

namespace UserApi.Repository.Data
{
    public class UserApiContext : DbContext
    {
        public UserApiContext (DbContextOptions<UserApiContext> options)
            : base(options)
        {
        }

        public DbSet<UserApi.Repository.Models.User> User { get; set; } = default!;
    }
}
