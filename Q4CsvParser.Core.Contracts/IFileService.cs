using System.IO;

namespace Q4CsvParser.Core.Contracts
{
    public interface IFileService
    {
        /// <summary>
        /// This file takes the inputStream and file name from the HttpPostedFileBase and save the file to the appData folder
        /// </summary>
        /// <param name="inputStream"></param>
        /// <param name="fileName"></param>
        /// <returns>The file path in the appData folder the file was saved to</returns>
        string StoreFile(Stream inputStream, string fileName);

        /// <summary>
        /// This function takes in the filePath of a csv file stored in the app data folder and return the string content
        /// of that file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>The contents of the file in a string</returns>
        string ReadFile(string filePath);
    }
}
