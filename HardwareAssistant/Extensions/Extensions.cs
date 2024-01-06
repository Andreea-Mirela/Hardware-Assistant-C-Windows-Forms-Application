using HardwareAssistant.Entities;

namespace HardwareAssistant.Extensions
{
    public static class Extensions
    {
        public static ComponentCompatibility Clone(this ComponentCompatibility componentCompatibility)
        {
            return new ComponentCompatibility()
            {
                ComponentCompatibilityId = componentCompatibility.ComponentCompatibilityId,
                ComponentCompatibilityCode = componentCompatibility.ComponentCompatibilityCode,
                ComponentCompatibilityName = componentCompatibility.ComponentCompatibilityName
            };
        }
    }
}
