using HardwareAssistant.Constants;
using HardwareAssistant.Entities;
using HardwareAssistant.Exceptions;
using HardwareAssistant.Extensions;
using HardwareAssistant.Json;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace HardwareAssistant.DataAccess
{
    public class JsonDataAccess : IDataAccess
    {
        #region GetComponentTypes
        public ComponentType[] GetComponentTypes()
        {
            string data = JsonFilesManager.GetFileContent(JsonSources.ComponentType);//se obtine continutul fisierului in variabila data
            ComponentType[] list = Deserialize<ComponentType[]>(data);//se apeleaza functia de deserializare cu input var data care contine continutul fisierului

            return list;
        }
        #endregion

        #region GetComponentCompatibilities
        public ComponentCompatibility[] GetComponentCompatibilities()
        {
            string data = JsonFilesManager.GetFileContent(JsonSources.ComponentCompatibility);
            var result = Deserialize<ComponentCompatibility[]>(data);

            return result;
        }
        #endregion

        #region GetComponents
        public Component[] GetComponents()
        {
            string data = JsonFilesManager.GetFileContent(JsonSources.Component);
            var components = Deserialize<Component[]>(data);

            ComponentCompatibility[] allComponentCompatibilities = GetComponentCompatibilities();

            foreach (var component in components)
            {
                if (component.CompatibilityTypeId.HasValue)
                    component.Compatibility = allComponentCompatibilities.First(x => x.ComponentCompatibilityId == component.CompatibilityTypeId.Value).Clone();
            }
            
            return components;
        }
        #endregion
        #region Processor
        public Processor[] GetProcessors()
        {
            Component[] allCcomponents = GetComponents();

            string data = JsonFilesManager.GetFileContent(JsonSources.Processor);
            var processors = Deserialize<Processor[]>(data);

            foreach (Processor processor in processors)
            {
                Component component = allCcomponents.First(x => x.ComponentId == processor.ProcessorId);
                processor.SetComponentFields(component);
            }

            return processors;
        }
        #endregion
        #region HardDisk
        public HardDisk[] GetHardDisks()
        {
            Component[] allCcomponents = GetComponents();

            string data = JsonFilesManager.GetFileContent(JsonSources.HardDisk);
            var harddisks = Deserialize<HardDisk[]>(data);

            foreach (HardDisk harddisk in harddisks)
            {
                Component component = allCcomponents.First(x => x.ComponentId == harddisk.HardDiskId);
                harddisk.SetComponentFields(component);
            }

            return harddisks;
        }
        #endregion
        #region RandomAccessMemories
        public RandomAccessMemory[] GetRandomAccessMemories()
        {
            Component[] allCcomponents = GetComponents();

            string data = JsonFilesManager.GetFileContent(JsonSources.RandomAccessMemory);
            var memories = Deserialize<RandomAccessMemory[]>(data);

            foreach (RandomAccessMemory memory in memories)
            {
                Component component = allCcomponents.First(x => x.ComponentId == memory.RandomAccessMemoryId);
                memory.SetComponentFields(component);
            }
            
            return memories;
        }
        #endregion
        #region SolidStateDrive
        public SolidStateDrive[] GetSolidStateDrives()
        {
            Component[] allCcomponents = GetComponents();

            string data = JsonFilesManager.GetFileContent(JsonSources.SolidStateDrive);
            var solidstatedrives = Deserialize<SolidStateDrive[]>(data);

            foreach (SolidStateDrive solidstatedrive in solidstatedrives)
            {
                Component component = allCcomponents.First(x => x.ComponentId == solidstatedrive.SolidStateDriveId);
                solidstatedrive.SetComponentFields(component);
            }
            return solidstatedrives;
        }
        #endregion
        #region Motherboard
        public Motherboard[] GetMotherboards()
        {
            Component[] allCcomponents = GetComponents();

            string data = JsonFilesManager.GetFileContent(JsonSources.Motherboard);
            var motherboards = Deserialize<Motherboard[]>(data);

            foreach (Motherboard each in motherboards)
            {
                Component component = allCcomponents.First(x => x.ComponentId == each.MotherboardId);
                each.SetComponentFields(component);
            }

            return motherboards;
        }
        #endregion
        #region VideoCard
        public VideoCard[] GetVideoCards()
        {
            Component[] allCcomponents = GetComponents();

            string data = JsonFilesManager.GetFileContent(JsonSources.VideoCard);
            var videoCards = Deserialize<VideoCard[]>(data);

            foreach (VideoCard each in videoCards)
            {
                Component component = allCcomponents.First(x => x.ComponentId == each.VideoCardId);
                each.SetComponentFields(component);
            }

            return videoCards;
        }
        #endregion
        #region Computer
        public Computer[] GetComputers()
        {
            string data = JsonFilesManager.GetFileContent(JsonSources.Computer);
            var computers = Deserialize<Computer[]>(data);

            return computers;
        }
        #endregion

        public void SaveRandomAccessMemories(RandomAccessMemory[] randomAccessMemories)
        {
            ValidateComponents(randomAccessMemories);

            int randomAccessMemoryTypeId = GetComponentTypeId(Enums.ComponentType.RAM);

            //incarcam toate componentele
            var allComponents = GetComponents();
            var nextComponentId = allComponents.Select(x => x.ComponentId.Value).Max() + 1;

            var componentsList = allComponents.Where(x => x.ComponentTypeId != randomAccessMemoryTypeId).ToList();

            foreach (var memory in randomAccessMemories)
            {
                if (!memory.ComponentId.HasValue) // daca nu are valoare inseamna ca e element adaugat
                {
                    memory.ComponentId = memory.RandomAccessMemoryId = nextComponentId;  // setam id pentru elementele adaugate
                    nextComponentId++;
                }

                componentsList.Add(memory.GetBase());
            }

            //salvam intai in fisierul Component
            string componentsInJsonFormat = Serialize(componentsList.ToArray(), new string[] { "Compatibility" });
            JsonFilesManager.SaveFileContent(JsonSources.Component, componentsInJsonFormat);

            //salvam si in fisierul RandomAccessMemory
            string data = Serialize(randomAccessMemories, true);
            JsonFilesManager.SaveFileContent(JsonSources.RandomAccessMemory, data);
        }
        
        

        public int GetComponentTypeId(Enums.ComponentType componentTypeCode)
        {
            var allComponentTypes = GetComponentTypes();
            int id = allComponentTypes.First(x => x.ComponentTypeCode == componentTypeCode.ToString()).ComponentTypeId;

            return id;
        }

        private void ValidateComponents(Component[] randomAccessMemories)
        {
            if (randomAccessMemories.Any(x => !x.ComponentTypeId.HasValue))
                throw new DataAccessException("In colectie exista componente pentru care nu s-a setat tipul!");

            if (randomAccessMemories.Any(x => !x.CompatibilityTypeId.HasValue))
                throw new DataAccessException("In colectie exista componente pentru care nu s-a setat compatibilitatea!");
        }

        #region GetComponentCompatibilities
        public ComponentCompatibility[] GetComponentCompatibilities(Enums.ComponentType componentTypeCode)
        {
            int componentTypeId = GetComponentTypeId(componentTypeCode);
            var result = GetComponentCompatibilities(componentTypeId);
            return result;
        }

        private ComponentCompatibility[] GetComponentCompatibilities(int componentTypeId)
        {
            int[] componentCompatibilityIds = GetComponentCompatibilityIds(componentTypeId);
            ComponentCompatibility[] allComponentCompatibilities = GetComponentCompatibilities();

            var result = allComponentCompatibilities.Where(x => componentCompatibilityIds.Contains(x.ComponentCompatibilityId)).ToArray();
            return result;
        }
        #endregion

        public ComponentTypeXComponentCompatibility[] GetComponentTypeXComponentCompatibilities()
        {
            string data = JsonFilesManager.GetFileContent(JsonSources.ComponentTypeXComponentCompatibility);
            var result = Deserialize<ComponentTypeXComponentCompatibility[]>(data);

            return result;
        }

        private int[] GetComponentCompatibilityIds(int componentTypeId)
        {
            ComponentTypeXComponentCompatibility[] all = GetComponentTypeXComponentCompatibilities();

            /*
            List<int> result = new List<int>();
            foreach (ComponentTypeXComponentCompatibility c in all)
            {
                if (c.ComponentTypeId == componentTypeId)
                    result.Add(c.ComponentCompatibilityId);
            }
            */
            
            var componentCompatibilities = all.Where(x => x.ComponentTypeId == componentTypeId).ToArray();
            int[] componentCompatibilityIds = componentCompatibilities.Select(x => x.ComponentCompatibilityId).ToArray();

            return componentCompatibilityIds;
        }

        #region Serializer
        private T Deserialize<T>(string data)
        {
            return JsonConvert.DeserializeObject<T>(data);
        }

        private string Serialize<T>(T data)
        {
            return JsonConvert.SerializeObject(data, Formatting.Indented);
        }

        private string Serialize<T>(T data, bool ignoreBaseType)
        {
            if (!ignoreBaseType)
                return Serialize(data);

            var contractResolver = new CustomJsonContractResolver();
            var inputType = typeof(T);
            var type = inputType.IsArray ? inputType.GetElementType() : inputType;
            var propertiesToIgnore = type.BaseType.GetProperties().Select(x => x.Name);

            foreach (var property in propertiesToIgnore)
                contractResolver.IgnoreProperty(type.BaseType, property);

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = contractResolver
            };

            return JsonConvert.SerializeObject(data, Formatting.Indented, serializerSettings);
        }

        private string Serialize<T>(T data, string[] fieldsToIgnore)
        {
            var contractResolver = new CustomJsonContractResolver();
            var inputType = typeof(T);
            var type = inputType.IsArray ? inputType.GetElementType() : inputType;

            foreach (var property in fieldsToIgnore)
                contractResolver.IgnoreProperty(type, property);

            var serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = contractResolver
            };

            return JsonConvert.SerializeObject(data, Formatting.Indented, serializerSettings);
        }
        #endregion
    }
}