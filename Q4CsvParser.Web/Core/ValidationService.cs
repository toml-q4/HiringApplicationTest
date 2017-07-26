using System;
using Q4CsvParser.Contracts;
using System.IO;

namespace Q4CsvParser.Web.Core
{
    /// <summary>
    /// This file must be unit tested
    /// </summary>
    public class ValidationService : IValidationService
    {
        /// <summary>
        /// Takes in a file name and determines whether it is a csv file or not.
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool IsCsvFile(string filename)
        {
            //TODO fill in your logic here
            var extension = Path.GetExtension(filename);
            if(extension.ToLower()==".csv")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
