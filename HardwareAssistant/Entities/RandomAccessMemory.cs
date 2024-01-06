namespace HardwareAssistant.Entities
{
    public class RandomAccessMemory : Component
    {
        public int? RandomAccessMemoryId { get; set; }
        public string Capacity { get; set; }
        public string Frequency { get; set; }
        public string Latency { get; set; }
        public string Voltage { get; set; }
        public string Timing { get; set; }
    }
}
