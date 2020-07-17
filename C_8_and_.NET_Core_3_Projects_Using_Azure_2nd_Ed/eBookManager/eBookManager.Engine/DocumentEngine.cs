using System;
using System.IO;

namespace eBookManager.Engine
{
    public class DocumentEngine
    {
        public (string fileName, string fileExtension, DateTime dateCreated, DateTime dateLastAccessed, long fileLength, bool error) GetFileProperties(string filePath)
        {
            var fileProperties = (
                fileName: string.Empty, 
                fileExtension: string.Empty, 
                dateCreated: DateTime.MinValue, 
                dateLastAccessed: DateTime.MinValue,
                fileLength: 0L,
                error: false
            );

            try
            {
                var fileInfo = new FileInfo(filePath);
                fileInfo.Refresh();
                fileProperties = (
                    fileInfo.Name,
                    fileInfo.Extension,
                    fileInfo.CreationTime,
                    fileInfo.LastAccessTime,
                    fileInfo.Length,
                    false
                );
            }
            catch (Exception)
            {
                fileProperties.error = true;
            }

            return fileProperties;
        }
    }
}