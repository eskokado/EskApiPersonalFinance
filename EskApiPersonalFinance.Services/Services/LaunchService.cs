using EskApiPersonalFinance.Domain.Entities;
using EskApiPersonalFinance.Domain.Interfaces.Repositories;
using EskApiPersonalFinance.Domain.Interfaces.Services;
using EskApiPersonalFinance.Domain.ViewModels.Launches;
using EskApiPersonalFinance.Services.Exceptions;
using System.Collections.Generic;
using System.Linq;

namespace EskApiPersonalFinance.Services.Services
{
    public class LaunchService : ILaunchService
    {
        private readonly ILaunchRepository _launchRepository;

        public LaunchService(ILaunchRepository userRepository)
        {
            _launchRepository = userRepository;
        }

        public void Add(LaunchViewModelInput launchModel)
        {
            var launchInsert = new Launch
            {
                AccountId = launchModel.AccountId,
                Date = launchModel.Date,
                LaunchType = launchModel.LaunchType,
                Value = launchModel.Value
            };

            _launchRepository.Add(launchInsert);
        }

        public IEnumerable<LaunchViewModelOutput> FindByAccountIdAndYearAndMonth(int accountId, int year, int month)
        {
            var launchers = _launchRepository.FindByAccountIdAndYearAndMonth(accountId, year, month);

            return launchers.Select(l => new LaunchViewModelOutput
            {
                LaunchId = l.LaunchId,
                AccountId = l.AccountId,
                Date = l.Date,
                LaunchType = l.LaunchType,
                Value = l.Value
            });
        }

        public IEnumerable<LaunchViewModelOutput> GetAll()
        {
            var launchers = _launchRepository.GetAll();

            return launchers.Select(l => new LaunchViewModelOutput
            {
                LaunchId = l.LaunchId,
                AccountId = l.AccountId,
                Date = l.Date,
                LaunchType = l.LaunchType,
                Value = l.Value
            });
        }

        public LaunchViewModelOutput GetById(int id)
        {
            Launch launch = _launchRepository.GetById(id);
            if (launch == null)
                throw new UnregisteredLaunch();

            return new LaunchViewModelOutput
            {
                LaunchId = launch.LaunchId,
                AccountId = launch.AccountId,
                Date = launch.Date,
                LaunchType = launch.LaunchType,
                Value = launch.Value
            };
        }

        public void Remove(int id)
        {
            Launch launch = _launchRepository.GetById(id);
            if (launch == null)
                throw new UnregisteredLaunch();
            _launchRepository.Remove(launch);
        }

        public LaunchViewModelOutput Update(int id, LaunchViewModelInput launchModel)
        {
            Launch launch = _launchRepository.GetById(id);
            if (launch == null)
                throw new UnregisteredLaunch();

            var launchUpdate = new Launch
            {
                LaunchId = id,
                AccountId = launchModel.AccountId,
                Date = launchModel.Date,
                LaunchType = launchModel.LaunchType,
                Value = launchModel.Value
            };

            _launchRepository.Update(launchUpdate);

            return new LaunchViewModelOutput
            {
                LaunchId = launchUpdate.LaunchId,
                AccountId = launchUpdate.AccountId,
                Date = launchUpdate.Date,
                LaunchType = launchUpdate.LaunchType,
                Value = launchUpdate.Value
            };

        }
    }
}
