using EskApiPersonalFinance.Domain.Entities;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Interfaces.Repositories
{
    public interface IAccountRepository : IRepositoryBase<Account>
    {
        Account FindByUserIdAndAgencyAndNumber(int userId, string agency, string number);
        Account FindByAgencyAndNumber(string agency, string number);
        IEnumerable<Account> FindByUserId(int userId);
    }
}
