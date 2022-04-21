using System;
using System.Collections.Generic;
using System.Text;

namespace Dekorater
{
    interface IRentable
    {
        String Description { get; }
        double CalculatePrice();
    }
}
