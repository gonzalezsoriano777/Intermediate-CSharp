using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public interface ILogger
    {
        // this are the interfaces that will be used to change the behavior of the applications
        void LogError(string message);
        void LogInfo(string message);
    }
}
