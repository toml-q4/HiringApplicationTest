using System.IO;
using Q4CsvParser.Core.Contracts;
using System;

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
            string fileNamePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), fileName);

            using (Stream file = File.Create(fileNamePath))
            {
                CopyStream(inputStream, file);
            }

            return fileNamePath;
        }



        /// <summary>
        /// Copies the contents of input to output. Doesn't close either stream.
        /// </summary>
        public static void CopyStream(Stream input, Stream output)
        {
            byte[] buffer = new byte[8 * 1024];
            int len;
            while ((len = input.Read(buffer, 0, buffer.Length)) > 0)
            {
                output.Write(buffer, 0, len);
            }
        }

        /// <summary>
        /// This function takes in the filePath of a csv file stored in the app data folder and return the string content
        /// of that file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>The contents of the file in a string</returns>
        public string ReadFile(string filePath)
        {

            return System.IO.File.ReadAllText(filePath);

        }
    }
}
