using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Proxy
{
    class LoggingProxyDataset : IDataset
    {
        private Dataset dataset;
        private DateTime timeStamp;
        private string log;

        public LoggingProxyDataset()

        public ReadOnlyCollection<List<string>> GetData()
        {
            return this.dataset.GetData();
        }
    }
}
