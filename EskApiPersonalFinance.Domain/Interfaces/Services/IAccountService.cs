using EskApiPersonalFinance.Domain.ViewModels.Accounts;
using EskApiPersonalFinance.Domain.ViewModels.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EskApiPersonalFinance.Domain.Interfaces.Services
{
    public interface IAccountService
    {
        Task<AccountViewModelOutput> Add(RegisterViewModelInput userModel);
        Task<AccountViewModelOutput> Update(int id, RegisterViewModelInput userModel);
        void Remove(int id);
        Task<IEnumerable<AccountViewModelOutput>> GetAll();
        Task<AccountViewModelOutput> GetById(int id);
        Task<AccountViewModelOutput> FindByUserIdAndAgencyAndNumber(int userId, string agency, string number);
        Task<IEnumerable<AccountViewModelOutput>> FindByUserId(int userId);
    }
}
