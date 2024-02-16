using Login.Models;
using System.Threading.Tasks;

namespace Login.DataAccess.Irepository
{
    public interface IUdRepository
    {
        public Task<int>InsertUser(User user);
        public Task<User>GetemailandPassword(string email, string password);
    }
}
