using EskApiPersonalFinance.Domain.Entities;
using EskApiPersonalFinance.Domain.Interfaces.Repositories;
using EskApiPersonalFinance.Domain.Interfaces.Services;
using EskApiPersonalFinance.Domain.ViewModels.Accounts;
using EskApiPersonalFinance.Services.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace EskApiPersonalFinance.Services.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public AccountViewModelOutput Add(AccountViewModelInput accountModel)
        {
            var entityAccount = _accountRepository.FindByAgencyAndNumber(accountModel.Agency, accountModel.Number);
            if (entityAccount != null)
                throw new AccountAlreadyRegistered();


            var accountInsert = new Account
            {
                Agency = accountModel.Agency,
                Number = accountModel.Number,
                Balance = accountModel.Balance
            };

            _accountRepository.Add(accountInsert);

            Account account = _accountRepository.FindByAgencyAndNumber(accountInsert.Agency, accountInsert.Number);

            return new AccountViewModelOutput
            {
                AccountId = account.AccountId,
                UserId = account.UserId,
                Agency = account.Agency,
                Number = account.Number,
                Balance = account.Balance
            };
        }

        public IEnumerable<AccountViewModelOutput> FindByUserId(int userId)
        {
            var accounts = _accountRepository.FindByUserId(userId);

            return accounts.Select(a => new AccountViewModelOutput
            {
                UserId = a.UserId,
                Agency = a.Agency,
                Number = a.Number,
                Balance = a.Balance
            });
        }

        public AccountViewModelOutput FindByUserIdAndAgencyAndNumber(int userId, string agency, string number)
        {
            Account account = _accountRepository.FindByUserIdAndAgencyAndNumber(userId, agency, number);

            return new AccountViewModelOutput
            {
                UserId = account.UserId,
                Agency = account.Agency,
                Number = account.Number,
                Balance = account.Balance
            };
        }

        public IEnumerable<AccountViewModelOutput> GetAll()
        {
            var accounts = _accountRepository.GetAll();

            return accounts.Select(a => new AccountViewModelOutput
            {
                UserId = a.UserId,
                Agency = a.Agency,
                Number = a.Number,
                Balance = a.Balance
            });
        }

        public AccountViewModelOutput GetById(int id)
        {
            Account account = _accountRepository.GetById(id);
            if (account == null)
                throw new UnregisteredAccount();

            return new AccountViewModelOutput
            {
                UserId = account.UserId,
                Agency = account.Agency,
                Number = account.Number,
                Balance = account.Balance
            };
        }

        public void Remove(int id)
        {
            Account account = _accountRepository.GetById(id);
            if (account == null)
                throw new UnregisteredAccount();

            _accountRepository.Remove(account);
        }

        public AccountViewModelOutput Update(int id, AccountViewModelInput accountModel)
        {
            var entityAccount = _accountRepository.GetById(id);
            if (entityAccount == null)
                throw new UnregisteredAccount();

            var accountUpdate = new Account
            {
                AccountId = id,
                Balance = accountModel.Balance,
                Agency = accountModel.Agency,
                Number = accountModel.Number,
                UserId = accountModel.UserId
            };

            _accountRepository.Update(accountUpdate);

            return new AccountViewModelOutput
            {
                AccountId = accountUpdate.AccountId,
                UserId = accountUpdate.UserId,
                Agency = accountUpdate.Agency,
                Number = accountUpdate.Number,
                Balance = accountUpdate.Balance
            };
        }
    }
}
