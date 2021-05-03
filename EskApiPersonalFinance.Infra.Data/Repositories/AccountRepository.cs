using EskApiPersonalFinance.Domain.Entities;
using EskApiPersonalFinance.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EskApiPersonalFinance.Infra.Data.Repositories
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public IEnumerable<Account> FindByUserId(int userId)
        {
            return Db.Accounts.Where(a => a.UserId == userId);
        }

        public Account FindByUserIdAndAgencyAndNumber(int userId, string agency, string number)
        {
            return (Account)Db.Accounts.Where(a => a.UserId == userId && a.Agency == agency && a.Number == number);
        }

        public Account FindByAgencyAndNumber(string agency, string number)
        {
            return (Account)Db.Accounts.Where(a => a.Agency == agency && a.Number == number);
        }
    }
}
