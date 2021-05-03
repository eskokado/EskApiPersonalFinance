using EskApiPersonalFinance.Domain.ViewModels.Accounts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EskApiPersonalFinance.Domain.Interfaces.Services
{
    public interface ILaunchService
    {
        Task<AccountViewModelOutput> Add(AccountViewModelInput userModel);
        Task<AccountViewModelOutput> Update(int id, AccountViewModelInput userModel);
        void Remove(int id);
        Task<IEnumerable<AccountViewModelOutput>> GetAll();
        Task<AccountViewModelOutput> GetById(int id);
        Task<IEnumerable<AccountViewModelOutput>> FindByAccountIdAndYearAndMonth(int accountId, int year, int month);
    }
}
