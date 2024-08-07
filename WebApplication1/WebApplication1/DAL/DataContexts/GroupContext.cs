using Microsoft.EntityFrameworkCore;
using WebApplication1.Entites;

namespace WebApplication1.DAL.DataContexts
{
    public class GroupContext : DbContext
    {
        public GroupContext(DbContextOptions<GroupContext> options):base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
