using eBookManager.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace eBookManager.Helper
{
    public static class ExtensionMethods
    {
        public static int ToInt(this string value, int defaultInteger = 0)
        {
            try
            {
                return int.TryParse(value, out var validInteger)
                    ? validInteger
                    : defaultInteger;
            }
            catch (Exception)
            {
                return defaultInteger;
            }
        }

        public static double ToMegabytes(this long bytes) => (bytes > 0)
            ? (bytes / 1024f) / 1024f
            : bytes;

        public static bool StorageSpaceExists(this List<StorageSpace> storageSpaces, string storageSpaceName, out int storageSpaceId)
        {
            var storageSpaceNameFound = storageSpaces.Any(ss => ss.Name.Equals(storageSpaceName));

            if (!storageSpaceNameFound)
            {
                storageSpaceId = 0;
                return false;
            }
            else
            {
                storageSpaceId = storageSpaces.Max(ss => ss.ID) + 1;
                return true;
            }
        }

        public async static Task WriteToDataStore(this List<StorageSpace> storageSpaces, string path, bool appendToExistingFile = false)
        {
            using var fileStream = File.Create(path);
            await JsonSerializer.SerializeAsync(fileStream, storageSpaces);
        }

        public async static Task<List<StorageSpace>> ReadFromDataStore(this List<StorageSpace> storageSpaces, string path)
        {
            if (!File.Exists(path))
            {
                var newFileStream = File.Create(path);
                newFileStream.Close();
            }

            using var fileStream = File.OpenRead(path);
            if (fileStream.Length == 0)
                return new List<StorageSpace>();

            var retVal = await JsonSerializer.DeserializeAsync<List<StorageSpace>>(fileStream);
            return retVal;
        }
    }
}
