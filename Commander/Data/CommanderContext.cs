using UserModel.Models;
using UserRolModel.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data
{
    public class CommanderContext : DbContext
    {
        public CommanderContext(DbContextOptions<CommanderContext> opt) : base(opt)
        {
            
        }

        public DbSet<UserRol> UserRol { get; set; }
        public DbSet<User> User { get; set; }

    }
}