using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Intermediate_CSharp
{
    public class FileLogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;      
        }

        public void LogError(string message)
        { 
            // writing data to a file
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine("ERROR: " + message);
            }
        }

        public void LogInfo(string message)
        {
            using(var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine("ERROR: " + message);
            }
        }

       
    }
}
