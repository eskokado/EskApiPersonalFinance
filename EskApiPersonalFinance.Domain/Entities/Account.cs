using System;
using System.Collections.Generic;

namespace EskApiPersonalFinance.Domain.Entities
{
    public class Account
    {
        public int AccountId { get; set; }

        public string Agency { get; set; }

        public string Number { get; set; }

        public decimal balance { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; }

        public IEnumerable<Launch> launches { get; }

        public bool SpecialAccount(Account account)
        {
            return account.User.Active && DateTime.Now.Year - account.User.CreatedAt.Year >= 5; 
        }
    }
}

