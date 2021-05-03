using System;
using System.Collections.Generic;
using System.Text;

namespace EskApiPersonalFinance.Services.Exceptions
{
    class UnregisteredLaunch : Exception
    {
        public UnregisteredLaunch()
            : base("Unregistered Launch")
        {

        }
    }
}
