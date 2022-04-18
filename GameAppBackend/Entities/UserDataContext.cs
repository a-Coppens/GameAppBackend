using GameAppBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace GameAppBackend.Entities
{
    public class UserDataContext : DbContext
    {
        public UserDataContext(DbContextOptions<UserDataContext> options): base(options) { }
        public UserDataContext() : base() { }

        public DbSet<UserModel> Users { get; set; }
    }
}
