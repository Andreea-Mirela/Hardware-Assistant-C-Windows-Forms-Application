using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAssistant.Entities
{
    public class VideoCard:Component
    {
        public int VideoCardId { get; set; }
        public string ChipsetManufacturer { get; set; }
        public string Technology { get; set; }
        public string GraphicProcessor { get; set; }
        public string Clock { get; set; }
        public string MemoryType { get; set; }
        public string MemorySize { get; set; }
        public string MemoryBus { get; set; }
        public string MemoryFrequency { get; set; }
    }
}
