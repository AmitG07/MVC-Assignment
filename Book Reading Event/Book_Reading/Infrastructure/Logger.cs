using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Reading.Infrastructure
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine("Logging" + message);
        }
    }
}
