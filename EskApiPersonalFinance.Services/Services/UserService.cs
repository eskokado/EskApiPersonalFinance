using EskApiPersonalFinance.Domain.Entities;
using EskApiPersonalFinance.Domain.Interfaces.Repositories;
using EskApiPersonalFinance.Domain.Interfaces.Services;
using EskApiPersonalFinance.Domain.ViewModels.Users;
using EskApiPersonalFinance.Services.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace EskApiPersonalFinance.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public UserViewModelOutput Add(RegisterViewModelInput userModel)
        {
            var entityUser = _userRepository.FindByEmail(userModel.Email);
            if (entityUser != null)
                throw new UserAlreadyRegistered();

            var userInsert = new User
            {
                Name = userModel.Name,
                Email = userModel.Email,
                Username = userModel.Username,
                Password = userModel.Password,
                Active = false
            };

            _userRepository.Add(userInsert);

            User user = _userRepository.FindByEmail(userInsert.Email);

            return new UserViewModelOutput
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                Name = user.Name
            };
        }

        public UserViewModelOutput FindByEmail(string email)
        {
            User user = _userRepository.FindByEmail(email);

            return new UserViewModelOutput
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                Name = user.Name
            };
        }

        public IEnumerable<UserViewModelOutput> FindByName(string name)
        {
            var users = _userRepository.FindByName(name);

            return users.Select(u => new UserViewModelOutput
            {
                UserId = u.UserId,
                Email = u.Email,
                Name = u.Name,
                Username = u.Username
            });
        }

        public UserViewModelOutput FindByUsername(string username)
        {
            var user = _userRepository.FindByUsename(username);
            return new UserViewModelOutput
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                Name = user.Name
            };
        }

        public IEnumerable<UserViewModelOutput> GetAll()
        {
            var users = _userRepository.GetAll();

            return users.Select(u => new UserViewModelOutput
            {
                UserId = u.UserId,
                Email = u.Email,
                Name = u.Name,
                Username = u.Username
            });
        }

        public UserViewModelOutput GetById(int id)
        {
            var user = _userRepository.GetById(id);
            if (user == null)
                throw new UnregisteredUser();

            return new UserViewModelOutput
            {
                UserId = user.UserId,
                Username = user.Username,
                Email = user.Email,
                Name = user.Name
            };
        }

        public void Remove(int id)
        {
            User user = _userRepository.GetById(id);
            _userRepository.Remove(user);
        }

        public UserViewModelOutput Update(int id, RegisterViewModelInput userModel)
        {
            var userUpdate = _userRepository.GetById(id);
            if (userUpdate == null)
                throw new UnregisteredUser();

            userUpdate.Name = userModel.Name;
            userUpdate.Email = userModel.Email;
            userUpdate.Username = userModel.Username;
            userUpdate.Password = userModel.Password;
            userUpdate.Active = false;

            _userRepository.Update(userUpdate);

            return new UserViewModelOutput
            {
                UserId = userUpdate.UserId,
                Username = userUpdate.Username,
                Email = userUpdate.Email,
                Name = userUpdate.Name
            };
        }
    }
}
