using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAssistant.Entities
{
    public class HardDisk:Component
    {
        public int HardDiskId { get; set; }
        public string Interface { get; set; }
        public string Capacity { get; set; }
        public string Buffer { get; set; }
        public string Speed { get; set; }
        public string FormFactor { get; set; }
    }
}
