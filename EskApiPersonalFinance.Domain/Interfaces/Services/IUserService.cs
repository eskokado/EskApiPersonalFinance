using EskApiPersonalFinance.Domain.ViewModels.Users;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Interfaces.Services
{
    public interface IUserService
    {
        UserViewModelOutput Add(RegisterViewModelInput userModel);
        UserViewModelOutput Update(int id, RegisterViewModelInput userModel);
        void Remove(int id);
        IEnumerable<UserViewModelOutput> GetAll();
        UserViewModelOutput GetById(int id);
        UserViewModelOutput FindByEmail(string email);
        UserViewModelOutput FindByUsername(string username);
        IEnumerable<UserViewModelOutput> FindByName();
    }
}
