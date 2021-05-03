using System;
using System.Collections.Generic;
using System.Text;

namespace EskApiPersonalFinance.Services.Exceptions
{
    class UnregisteredUser : Exception
    {
        public UnregisteredUser()
            : base("Unregistered User")
        {

        }
    }
}
