namespace HardwareAssistant.Entities
{
    public class Computer
    {
        public int ComputerId { get; set; }
        public string ComputerCode { get; set; }
        public string ComputerName { get; set; }
        public string Platform { get; set; }
        public int ProcessorId { get; set; }
        public int RandomAccessMemoryId { get; set; }
        public int HardDiskId { get; set; }
        public int? SolidStateDriveId { get; set; }
        public string VideoCardType { get; set; }
        public int? VideoCardId { get; set; }
        public int MotherboardId { get; set; }
        public string Size { get; set; }
        public string Weight { get; set; }
    }
}
