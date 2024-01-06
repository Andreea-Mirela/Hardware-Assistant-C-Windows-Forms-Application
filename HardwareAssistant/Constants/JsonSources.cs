namespace HardwareAssistant.Constants
{
    public struct JsonDirectories
    {
        public static string FilesDirectory = "JsonDatabase";
    }

    public struct JsonSources
    {
        //Lista cu numele fisierelor din care importam date
        public static string
            ComponentType = "ComponentType.json",
            ComponentCompatibility = "ComponentCompatibility.json",
            ComponentTypeXComponentCompatibility = "ComponentTypeXComponentCompatibility.json",
            RandomAccessMemory = "RandomAccessMemory.json",
            Component = "Component.json",
            Processor = "Processor.json",
            HardDisk="HardDisk.json",
            SolidStateDrive= "SolidStateDrive.json",
            VideoCard= "VideoCard.json",
            Motherboard="Motherboard.json",
            Computer= "Computer.json";
    }
}
