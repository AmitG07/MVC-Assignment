using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Reading.Infrastructure
{
    public interface ILogger
    {
        void Log(String message);
    }
}
