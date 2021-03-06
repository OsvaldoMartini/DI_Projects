﻿using System;
using Container.IoC.Business.Interfaces;

namespace Container.IoC.Business.Concrete
{
    public class Logger:ILogger
    {
        public void Log(string message)
        {
            //log message to log file
            Console.WriteLine(string.Format("Log entry @ {0}: {1}",DateTime.Now, message));
            Console.WriteLine("");
        }
    }
}
