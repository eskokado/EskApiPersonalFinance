using EskApiPersonalFinance.Domain.Entities;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Interfaces.Repositories
{
    public interface ILaunchRepository : IRepositoryBase<Launch>
    {
        IEnumerable<Launch> FindByAccountIdAndYearAndMonth(int accountId, int year, int month);
    }
}
