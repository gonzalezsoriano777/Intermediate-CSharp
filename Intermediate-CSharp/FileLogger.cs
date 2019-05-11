using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// this is the user namespace used for grabbing the StreamWriter method
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
            // easier way to numerate through both LogError and LogInfo
            Log(message, "ERROR");

            // freeing external resources that are not managed by CLR

            //streamWriter.Dispose();        
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message, string messageType)
        {
            // writing data to the file
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
            }
        }

    }
}
