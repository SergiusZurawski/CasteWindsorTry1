using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.GettingStarted
{
    interface ICompositionRoot
    {
        void LogMessage(string message);
    }
}
