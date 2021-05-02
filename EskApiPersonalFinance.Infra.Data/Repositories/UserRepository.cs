using EskApiPersonalFinance.Domain.Entities;
using EskApiPersonalFinance.Domain.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace EskApiPersonalFinance.Infra.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public User FindByEmail(string email)
        {
            return (User)Db.Users.Where(u => u.Email == email);
        }

        public IEnumerable<User> FindByName(string name)
        {
            return Db.Users.Where(u => u.Name.ToLower().Contains(name.ToLower()));
        }

        public User FindByUsename(string username)
        {
            return (User)Db.Users.Where(u => u.Username == username);
        }
    }
}
