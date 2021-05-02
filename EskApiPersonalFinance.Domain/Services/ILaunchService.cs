using EskApiPersonalFinance.Domain.ViewModels.Accounts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EskApiPersonalFinance.Domain.Services
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
