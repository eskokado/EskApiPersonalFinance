using EskApiPersonalFinance.Domain.Entities;
using System;

namespace EskApiPersonalFinance.Application.ViewModels.Launches
{
    public class LaunchViewModelOutput
    {
        public int LaunchId { get; set; }

        public DateTime Date { get; set; }

        public decimal Value { get; set; }

        public LaunchType LaunchType { get; set; }

        public int AccountId { get; set; }

        public virtual Account Account { get; set; }
    }
}
