using System;
using System.Collections.Generic;
using System.Text;

namespace EskApiPersonalFinance.Services.Exceptions
{
    class AccountAlreadyRegistered : Exception
    {
        public AccountAlreadyRegistered()
            : base("Account already registered")
        {

        }
    }
}
