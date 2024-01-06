using HardwareAssistant.Constants;
using System.IO;

namespace HardwareAssistant.DataAccess
{
    public static class JsonFilesManager
    {
        public static string GetFileContent(string fileName)
        {
            string filePath = Path.Combine(JsonDirectories.FilesDirectory, fileName);
            string fileContent = File.ReadAllText(filePath);

            return fileContent;
        }

        public static void SaveFileContent(string fileName, string fileContent)
        {
            string filePath = Path.Combine(JsonDirectories.FilesDirectory, fileName);
            File.WriteAllText(filePath, fileContent);
        }
    }
}
