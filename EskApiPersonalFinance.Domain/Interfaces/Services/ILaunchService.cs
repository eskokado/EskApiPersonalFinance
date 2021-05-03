using EskApiPersonalFinance.Domain.ViewModels.Launches;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Interfaces.Services
{
    public interface ILaunchService
    {
        void Add(LaunchViewModelInput launchModel);
        LaunchViewModelOutput Update(int id, LaunchViewModelInput launchModel);
        void Remove(int id);
        IEnumerable<LaunchViewModelOutput> GetAll();
        LaunchViewModelOutput GetById(int id);
        IEnumerable<LaunchViewModelOutput> FindByAccountIdAndYearAndMonth(int accountId, int year, int month);
    }
}
