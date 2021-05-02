using EskApiPersonalFinance.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_api.Models.Courses
{
    public class AccountViewModelOutput
    {
        public int AccountId { get; set; }

        public string Agency { get; set; }

        public string Number { get; set; }

        public decimal Balance { get; set; }

        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}
