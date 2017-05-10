using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualBasic.FileIO;
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
        private const string UploadFilePath = "~//App_Data//uploads//";

        /// <summary>
        /// This file takes the file from the HttpPostedFileBase and saves the file to the appData folder
        /// </summary>
        /// <param name="file"></param>
        /// <returns>The file path in the appData folder the file was saved to</returns>
        public string StoreFile(HttpPostedFileBase file)
        {
            //TODO fill in your logic here
            string fileName = Path.GetFileName(file.FileName);
            file.SaveAs(Path.Combine(UploadFilePath, fileName));
            string fullPath = UploadFilePath + fileName;

            return fullPath;
        }

        /// <summary>
        /// This function takes in the filePath of a csv file stored in the app data folder and return the string content
        /// of that file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>The contents of the file in a string</returns>
        public string ReadFile(string filePath)
        {

            string[] readText = File.ReadAllLines(filePath);

            return String.Join(" ", readText); ;
        }
    }
}
