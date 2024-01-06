using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAssistant.Entities
{
    public class SolidStateDrive:Component
    {
        public int SolidStateDriveId { get; set; }
        public string Interface { get; set; }
        public string Capacity { get; set; }
        public string Controller { get; set; }
        public string FormFactor { get; set; }
        public string ReadSpeed { get; set; }
        public string WriteSpeed { get; set; }
    }
}
