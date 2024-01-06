namespace HardwareAssistant.Entities
{
    public class Component
    {
        public int? ComponentId { get; set; }
        public int? ComponentTypeId { get; set; }
        public int? CompatibilityTypeId { get; set; }
        public string ComponentCode { get; set; }
        public string ComponentName { get; set; }
        public string Manufacturer { get; set; }
        public string Series { get; set; }

        public ComponentCompatibility Compatibility { get; set; }

        public void SetComponentFields(Component component)
        {
            ComponentId = component.ComponentId;
            ComponentTypeId = component.ComponentTypeId;
            CompatibilityTypeId = component.CompatibilityTypeId;
            ComponentCode = component.ComponentCode;
            ComponentName = component.ComponentName;
            Manufacturer = component.Manufacturer;
            Series = component.Series;
            Compatibility = component.Compatibility;
        }
        
        public Component GetBase()
        {
            return new Component()
            {
                ComponentId = this.ComponentId,
                ComponentTypeId = ComponentTypeId,
                CompatibilityTypeId = CompatibilityTypeId,
                ComponentCode = ComponentCode,
                ComponentName = ComponentName,
                Manufacturer = Manufacturer,
                Series = Series
            };
        }
    }
}
