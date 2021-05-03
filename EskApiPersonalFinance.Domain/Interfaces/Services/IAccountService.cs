using EskApiPersonalFinance.Domain.ViewModels.Accounts;
using EskApiPersonalFinance.Domain.ViewModels.Users;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Interfaces.Services
{
    public interface IAccountService
    {
        AccountViewModelOutput Add(RegisterViewModelInput userModel);
        AccountViewModelOutput Update(int id, RegisterViewModelInput userModel);
        void Remove(int id);
        IEnumerable<AccountViewModelOutput> GetAll();
        AccountViewModelOutput GetById(int id);
        AccountViewModelOutput FindByUserIdAndAgencyAndNumber(int userId, string agency, string number);
        IEnumerable<AccountViewModelOutput> FindByUserId(int userId);
    }
}
