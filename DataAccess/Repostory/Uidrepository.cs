using Login.DataAccess.Irepository;
using Login.Dbcontext;
using Login.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace Login.DataAccess.Repostory
{
    public class Uidrepository : IUdRepository
    {
        public projectDbcontext db;
        public Uidrepository(projectDbcontext _db)
        {
            this.db = _db;
        }
      public async Task<User> GetemailandPassword(string email, string password)
        {
            var use = await db.Users.FirstOrDefaultAsync(x => x.email == email && x.password == password);
            return use;
        }

        public async Task<int>InsertUser(User user)
        {
            await db.Users.AddAsync(user);
            return await db.SaveChangesAsync();
        }
    }
}
