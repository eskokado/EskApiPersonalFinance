using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EskApiPersonalFinance.Domain.ViewModels.Users
{
    public class UserViewModelOutput
    {
        public int UserId { get; set; }

        public string Username { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
