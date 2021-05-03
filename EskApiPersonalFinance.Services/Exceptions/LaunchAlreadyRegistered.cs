using System;
using System.Collections.Generic;
using System.Text;

namespace EskApiPersonalFinance.Services.Exceptions
{
    class LaunchAlreadyRegistered : Exception
    {
        public LaunchAlreadyRegistered()
            : base("Launch already registered")
        {

        }
    }
}
