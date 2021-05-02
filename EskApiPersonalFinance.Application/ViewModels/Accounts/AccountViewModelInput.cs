using System.ComponentModel.DataAnnotations;

namespace EskApiPersonalFinance.Application.ViewModels.Accounts
{
    public class AccountViewModelInput
    {
        [Required(ErrorMessage = "Agency is required")]
        public string Agency { get; set; }

        [Required(ErrorMessage = "Number is required")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Balance is required")]
        public decimal Balance { get; set; }

        public int UserId { get; set; }
    }
}
