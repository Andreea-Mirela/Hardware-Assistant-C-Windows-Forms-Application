using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareAssistant.Entities
{
    public class Motherboard:Component
    {
        public int MotherboardId { get; set; }
        public string ChipsetManufacturer { get; set; }
        public string ChipsetModel { get; set; }
        public int ProcessorCompatibilityId { get; set; }
        public string SupportedProcessors { get; set; }
        public string RAID { get; set; }
        public int VideoCardCompatibilityId { get; set; }
        public string AudioCard { get; set; }
        public string AudioChipset { get; set; }
        public string NetworkCard { get; set; }
        public string NetworkChipset { get; set; }
        public int StorageCompatibilityId { get; set; }
        public int StoragePortsNumber { get; set; }
        public int MemoryCompatibilityId { get; set; }
        public string MaximumMemory { get; set; }
        public int MemorySlotsNumber { get; set; }
        public string MemoryTechnology { get; set; }
        public string SupportedFrequencies { get; set; }
        public string Connectors { get; set; }

    }
}
