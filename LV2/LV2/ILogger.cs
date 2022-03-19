using System;
using System.Collections.Generic;
using System.Text;

namespace LV2
{
    interface ILogger
    {
        public void Log(ILogable data);
    }
}
