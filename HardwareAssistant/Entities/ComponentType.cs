namespace HardwareAssistant.Entities
{
    public class ComponentType
    {
        public int ComponentTypeId { get; set; }
        public string ComponentTypeCode { get; set; }
        public string ComponentTypeName { get; set; }

        public ComponentCompatibility[] Compatibilities { get; set; }
    }
}
