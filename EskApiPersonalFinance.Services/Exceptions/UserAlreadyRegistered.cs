using System;
using System.Collections.Generic;
using System.Text;

namespace EskApiPersonalFinance.Services.Exceptions
{
    class UserAlreadyRegistered : Exception
    {
        public UserAlreadyRegistered()
            : base("User already registered")
        {

        }
    }
}
