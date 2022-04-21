using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
