using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate_CSharp
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;      
        }

        public void LogError(string message)
        {
            using ()
            {

            } 
            
        }

        public void LogInfo(string message)
        {
            using ()
            {

            }
        }
    }
}
