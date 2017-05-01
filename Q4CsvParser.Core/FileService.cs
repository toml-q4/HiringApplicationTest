using System.IO;
using Q4CsvParser.Core.Contracts;

namespace Q4CsvParser.Core
{
    /// <summary>
    /// This file does not need to be unit testable.
    /// Bonus Task:
    /// - Make this file unit testable using the adapter pattern for your file system interactions
    /// - Unit test this file
    /// </summary>
    public class FileService : IFileService
    {
        private const string UploadFilePath = "~/App_Data/uploads";

        /// <summary>
        /// This file takes the inputStream and file name from the HttpPostedFileBase and save the file to the appData folder
        /// </summary>
        /// <param name="inputStream"></param>
        /// <param name="fileName"></param>
        /// <returns>The file path in the appData folder the file was saved to</returns>
        public string StoreFile(Stream inputStream, string fileName)
        {
            // configurable as per environment
            string filePath = @"C:\inetpub\Q4Web-HiringApplicationTest-master\Q4CsvParser.Web\App_Data\uploads\" + fileName ;
            using (var fileStream = File.Create(filePath))
            {
                inputStream.Seek(0, SeekOrigin.Begin);
                inputStream.CopyTo(fileStream);
            }
            return filePath;
        }

        /// <summary>
        /// This function takes in the filePath of a csv file stored in the app data folder and return the string content
        /// of that file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>The contents of the file in a string</returns>
        public string ReadFile(string filePath)
        {
            var fileContent = File.ReadAllText(filePath);
            return fileContent;
        }
    }
    
}
