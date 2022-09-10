using System;
using System.Collections.Generic;
using System.Text;

namespace Promatrač
{
    class SystemDataProvider : SimpleSystemDataProvider
    {
        private float previousCPULoad;
        private float previousRAMAvailable;
        public SystemDataProvider() : base()
        {
            this.previousCPULoad = this.CPULoad;
            this.previousRAMAvailable = this.AvailableRAM;
        }
        public float GetCPULoad()
        {
            float currentLoad = this.CPULoad;
            if (/*currentLoad != this.previousCPULoad*/ currentLoad - previousCPULoad >= (currentLoad - previousCPULoad)*0.1)
            {
                this.Notify();
            }
            this.previousCPULoad = currentLoad;
            return currentLoad;
        }
        public float GetAvailableRAM()
        {
            // implementation missing
            float currentLoad = this.AvailableRAM;
            if(/*currentLoad != this.previousRAMAvailable*/ currentLoad - previousRAMAvailable >= (currentLoad - previousRAMAvailable) * 0.1) 
            {
                this.Notify();
            }
            this.previousRAMAvailable = currentLoad;
            return currentLoad;
        }
    }
}
