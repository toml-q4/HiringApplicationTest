using System.IO;
using Q4CsvParser.Core.Contracts;

namespace Q4CsvParser.Core
{
    /// <summary>
    /// This file does not need to be unit testable.
    /// Bonus Marks:
    /// - Make this file unit testable using the adapter pattern for your file system interactions
    /// </summary>
    public class FileService : IFileService
    {
        private const string UploadFilePath = "~/App_Data/uploads";

        public string ReadFile(string filePath)
        {
            //TODO fill in your logic here
            throw new System.NotImplementedException();
        }

        public string StoreFile(Stream inputStream, string fileName)
        {
            //TODO fill in your logic here
            return null;
        }
    }
}
