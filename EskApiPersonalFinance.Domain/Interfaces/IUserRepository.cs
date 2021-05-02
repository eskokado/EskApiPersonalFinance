using EskApiPersonalFinance.Domain.Entities;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Interfaces
{
    public interface IUserRepository : IRepositoryBase<User>
    {
        User FindByEmail(string email);
        User FindByUsename(string username);
        IEnumerable<User> FindByName(string name);
    }
}
