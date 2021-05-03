using EskApiPersonalFinance.Domain.ViewModels.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EskApiPersonalFinance.Domain.Interfaces.Services
{
    public interface IUserService
    {
        Task<UserViewModelOutput> Add(RegisterViewModelInput userModel);
        Task<UserViewModelOutput> Update(int id, RegisterViewModelInput userModel);
        void Remove(int id);
        Task<IEnumerable<UserViewModelOutput>> GetAll();
        Task<UserViewModelOutput> GetById(int id);
        Task<UserViewModelOutput> FindByEmail(string email);
        Task<UserViewModelOutput> FindByUsername(string username);
        Task<IEnumerable<UserViewModelOutput>> FindByName();
    }
}
