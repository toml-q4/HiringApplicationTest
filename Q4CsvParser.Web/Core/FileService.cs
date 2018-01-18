using System;
using System.IO;
using System.Web;
using Q4CsvParser.Contracts;

namespace Q4CsvParser.Web.Core
{
    /// <summary>
    /// This file does not need to be unit testable.
    /// Bonus Task:
    /// - Make this file unit testable using the adapter pattern for your file system interactions
    /// - Unit test this file
    /// </summary>
    public class FileService : IFileService
    {
        private const string UploadFilePath = @"App_Data\uploads\";

        /// <summary>
        /// This file takes the file from the HttpPostedFileBase and saves the file to the appData folder
        /// </summary>
        /// <param name="file"></param>
        /// <returns>The file path in the appData folder the file was saved to</returns>
        public string StoreFile(HttpPostedFileBase file)
        {
            
            try {

                var path = AppDomain.CurrentDomain.BaseDirectory + UploadFilePath + file.FileName;

                using (var fileStream = File.Create(path))
                {
                    file.InputStream.Seek(0, SeekOrigin.Begin);
                    file.InputStream.CopyTo(fileStream);
                    return path;
                }
            }
            catch (Exception) {}
            return null;
        }

        /// <summary>
        /// This function takes in the filePath of a csv file stored in the app data folder and return the string content
        /// of that file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>The contents of the file in a string</returns>
        public string ReadFile(string filePath)
        {
            try {
                var csvRows = File.ReadAllLines(filePath);
                return string.Join(";", csvRows);
            }
            catch (Exception) {
                return null;
            }           
            
        }
    }
}
