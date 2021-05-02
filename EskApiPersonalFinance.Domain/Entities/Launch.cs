using System;
using System.Collections.Generic;
using System.Text;

namespace EskApiPersonalFinance.Domain.Entities
{

    public enum LaunchType
    {
        Income,
        Expense
    }

    public class Launch
    {
        public int LaunchId { get; set; }

        public DateTime Date { get; set; }

        public decimal Value { get; set; }

        public LaunchType LaunchType { get; set; }

        public int AccountId { get; set; }

        public virtual Account Account { get; }
    }
}
