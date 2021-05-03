using EskApiPersonalFinance.Domain.Entities;
using EskApiPersonalFinance.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EskApiPersonalFinance.Infra.Data.Repositories
{
    public class LaunchRepository : RepositoryBase<Launch>, ILaunchRepository
    {
        public IEnumerable<Launch> FindByAccountIdAndYearAndMonth(int accountId, int year, int month)
        {
            return Db.Launches.Where(l => l.AccountId == accountId && l.Date.Year == year && l.Date.Month == month);
        }
    }
}
