using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAssistant.Entities
{
    public class Processor:Component
    {
        public int ProcessorId { get; set; }
        public string CoreName { get; set; }
        public int CoresNumber { get; set; }
        public int ThreadsNumber { get; set; }
        public string Frequency { get; set; }
        public string TurboFrequency { get; set; }
        public string Technology { get; set; }
        public string TotalDissipatedPower { get; set; }
        public string IntegratedGraphicsCard { get; set; }
    }
}
