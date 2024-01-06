using HardwareAssistant.Constants;
using HardwareAssistant.Entities;
using System;

namespace HardwareAssistant.DataAccess
{
    public class SqlDataAccess : IDataAccess
    {
        public ComponentType[] GetComponentTypes()
        {
            throw new NotImplementedException();
        }

        public Component[] GetComponents()
        {
            throw new NotImplementedException();
        }

        public ComponentCompatibility[] GetComponentCompatibilities()
        {
            throw new NotImplementedException();
        }

        public RandomAccessMemory[] GetRandomAccessMemories()
        {
            throw new NotImplementedException();
        }
        public HardDisk[] GetHardDisks()
        {
            throw new NotImplementedException();
        }
        public Processor[] GetProcessors()
        {
            throw new NotImplementedException();
        }

        public SolidStateDrive[] GetSolidStateDrives()
        {
            throw new NotImplementedException();
        }
        public Motherboard[] GetMotherboards()
        {
            throw new NotImplementedException();
        }
        public VideoCard[] GetVideoCards()
        {
            throw new NotImplementedException();
        }
        public Computer[] GetComputers()
        {
            throw new NotImplementedException();
        }

        public void SaveRandomAccessMemories(RandomAccessMemory[] randomAccessMemories)
        {
            throw new NotImplementedException();
        }

        public int GetComponentTypeId(Enums.ComponentType componentTypeCode)
        {
            throw new NotImplementedException();
        }

        public ComponentCompatibility[] GetComponentCompatibilities(Enums.ComponentType componentTypeCode)
        {
            throw new NotImplementedException();
        }
    }
}
