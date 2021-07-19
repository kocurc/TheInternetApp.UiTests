using System.IO;

namespace TheInternetApp.UiTests.Helpers
{
    internal static class FileHelper
    {
        public static string ReadFile(string filePath)
        {
            using var streamReader = File.OpenText(filePath);

            return streamReader.ReadToEnd();
        }
    }
}
