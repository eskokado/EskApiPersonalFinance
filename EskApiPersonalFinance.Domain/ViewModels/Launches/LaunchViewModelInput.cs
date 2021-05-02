using EskApiPersonalFinance.Domain.Entities;
using System;
using System.ComponentModel.DataAnnotations;

namespace EskApiPersonalFinance.Domain.ViewModels.Launches
{
    public class LaunchViewModelInput
    {
        [Required(ErrorMessage = "Date is required")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Value is required")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "LaunchType is required")]
        public LaunchType LaunchType { get; set; }

        [Required(ErrorMessage = "AccountId is required")]
        public int AccountId { get; set; }
    }
}
