using System;

namespace DI.Coupled.Concrete
{
    public class Logger
    {
        public void Log(string message)
        {
            //log message to log file
            Console.WriteLine(string.Format("Log entry @ {0}: {1}",DateTime.Now, message));
            Console.WriteLine("");
        }
    }
}
