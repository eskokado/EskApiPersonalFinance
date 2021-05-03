using EskApiPersonalFinance.Domain.ViewModels.Accounts;
using EskApiPersonalFinance.Domain.ViewModels.Users;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Interfaces.Services
{
    public interface IAccountService
    {
        AccountViewModelOutput Add(AccountViewModelInput accountModel);
        AccountViewModelOutput Update(int id, AccountViewModelInput accountModel);
        void Remove(int id);
        IEnumerable<AccountViewModelOutput> GetAll();
        AccountViewModelOutput GetById(int id);
        AccountViewModelOutput FindByUserIdAndAgencyAndNumber(int userId, string agency, string number);
        IEnumerable<AccountViewModelOutput> FindByUserId(int userId);
    }
}
