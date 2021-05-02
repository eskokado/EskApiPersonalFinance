using EskApiPersonalFinance.Domain.Entities;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Interfaces
{
    public interface ILaunchRepository : IRepositoryBase<Launch>
    {
        IEnumerable<Launch> FindByAccountIdAndYearAndMonth(int accountId, int year, int month);
    }
}
