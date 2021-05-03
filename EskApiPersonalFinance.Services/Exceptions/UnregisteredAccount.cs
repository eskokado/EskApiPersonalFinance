using System;
using System.Collections.Generic;
using System.Text;

namespace EskApiPersonalFinance.Services.Exceptions
{
    class UnregisteredAccount : Exception
    {
        public UnregisteredAccount()
            : base("Unregistered Account")
        {

        }
    }
}
