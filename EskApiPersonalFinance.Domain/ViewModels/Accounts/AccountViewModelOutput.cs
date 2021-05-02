using EskApiPersonalFinance.Domain.Entities;

namespace EskApiPersonalFinance.Domain.ViewModels.Accounts
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
