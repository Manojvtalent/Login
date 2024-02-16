using Login.Models;
using Microsoft.EntityFrameworkCore;

namespace Login.Dbcontext
{
    public class projectDbcontext:DbContext
    {
        public projectDbcontext(DbContextOptions<projectDbcontext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
