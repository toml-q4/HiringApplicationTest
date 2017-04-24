using System;
using Q4CsvParser.Core.Contracts;
using Q4CsvParser.Domain;

namespace Q4CsvParser.Core
{
    /// <summary>
    /// This file must be unit tested.
    /// </summary>
    public class ParsingService : IParsingService
    {
        /// <summary>
        /// Accepts a string with the contents of the csv file in it and should return a parsed csv file.
        /// </summary>
        /// <param name="fileContent"></param>
        /// <returns></returns>
        public CsvTable ParseCsv(string fileContent)
        {
            //TODO fill in your logic here
            throw new NotImplementedException();
        }
    }
}
