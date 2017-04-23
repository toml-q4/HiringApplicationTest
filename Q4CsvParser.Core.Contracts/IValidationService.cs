namespace Q4CsvParser.Core.Contracts
{
    public interface IValidationService
    {
        /// <summary>
        /// Takes in a file name and determins whether it is a csv file or not
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        bool IsCsvFile(string filename);
    }
}
