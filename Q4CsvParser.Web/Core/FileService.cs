using System;
using System.Web;
using Q4CsvParser.Contracts;
using System.IO;
using Microsoft.VisualBasic.FileIO;

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
        private const string UploadFilePath = "~/App_Data/uploads/";

        /// <summary>
        /// This file takes the file from the HttpPostedFileBase and saves the file to the appData folder
        /// </summary>
        /// <param name="file"></param>
        /// <returns>The file path in the appData folder the file was saved to</returns>
        public string StoreFile(HttpPostedFileBase file)
        {
            //TODO fill in your logic here
            // store file in app data folder 
            string fileName = file.FileName;
            string location = "";
            try
            {
                if (file.ContentLength > 0)
                {
                    fileName = Path.GetFileName(file.FileName);
                    location = Path.Combine(
                            System.Web.HttpContext.Current.Server.MapPath(UploadFilePath), fileName);
                    file.SaveAs(location);

                }
            }
            catch(Exception eex)
            {
                location = "";
            }
           
            
            return location; 
        }

        /// <summary>
        /// This function takes in the filePath of a csv file stored in the app data folder and return the string content
        /// of that file
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns>The contents of the file in a string</returns>
        public string ReadFile(string filePath)
        {
            //TODO fill in your logic here
            string fileContent = "";
            // read file 
            // option 1 : split each line with , or use .net fucntionlaity : textfieldparser 
            string[] fieldsContent = { };
            using (TextFieldParser myParser = new TextFieldParser(filePath))
            {

                myParser.TextFieldType = FieldType.Delimited;
                myParser.SetDelimiters(new string[] { "," });



                // Skip the row with the column names header row 
                // don't skip 
             //   myParser.ReadLine();
             fileContent =  myParser.ReadToEnd();
            //    while (!myParser.EndOfData)
            //    {
            //        // Read current line fields, pointer moves to the next line.
            //     fieldsContent   = myParser.ReadFields();
            //        string strdate = fieldsContent[0];
            //        string address = fieldsContent[1];
            //    }
            }
            //// convert all fieldsTostring 
            //fileContent = fieldsContent.ToString();
            return fileContent; 
        }
    }
}
