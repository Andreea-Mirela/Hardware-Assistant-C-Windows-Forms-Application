using HardwareAssistant.Constants;
using HardwareAssistant.Entities;

namespace HardwareAssistant.DataAccess
{
    public interface IDataAccess
    {
        ComponentType[] GetComponentTypes();
        Component[] GetComponents();
        ComponentCompatibility[] GetComponentCompatibilities();
        RandomAccessMemory[] GetRandomAccessMemories();
        Processor[] GetProcessors();
        HardDisk[] GetHardDisks();
        SolidStateDrive[] GetSolidStateDrives();
        Motherboard[] GetMotherboards();
        VideoCard[] GetVideoCards();
        Computer[] GetComputers();
        void SaveRandomAccessMemories(RandomAccessMemory[] randomAccessMemories);
        int GetComponentTypeId(Enums.ComponentType componentTypeCode);
        ComponentCompatibility[] GetComponentCompatibilities(Enums.ComponentType componentTypeCode);
    }
}
