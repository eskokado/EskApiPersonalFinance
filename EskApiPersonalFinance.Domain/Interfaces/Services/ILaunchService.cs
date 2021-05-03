using EskApiPersonalFinance.Domain.ViewModels.Accounts;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Interfaces.Services
{
    public interface ILaunchService
    {
        AccountViewModelOutput Add(AccountViewModelInput userModel);
        AccountViewModelOutput Update(int id, AccountViewModelInput userModel);
        void Remove(int id);
        IEnumerable<AccountViewModelOutput> GetAll();
        AccountViewModelOutput GetById(int id);
        IEnumerable<AccountViewModelOutput> FindByAccountIdAndYearAndMonth(int accountId, int year, int month);
    }
}
