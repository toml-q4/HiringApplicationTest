
using System.IO;
using Q4CsvParser.Contracts;

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
            string FileExtension = Path.GetExtension(filename);
            if (FileExtension == ".csv")
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
