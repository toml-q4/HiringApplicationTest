using Q4CsvParser.Domain;

namespace Q4CsvParser.Core.Contracts
{
    public interface IParsingService
    {
        /// <summary>
        /// Accepts a string with the contents of the csv file in it and should return a parsed csv file.
        /// </summary>
        /// <param name="fileContent"></param>
        /// <returns></returns>
        CsvTable ParseCsv(string fileContent);
    }
}
