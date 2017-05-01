using System.IO;
using Q4CsvParser.Domain;

namespace Q4CsvParser.Core.Contracts
{
    public interface ICsvFileHandler
    {
        /// <summary>
        /// Takes in an input stream from HttpPostedFileBase and returns a parsed CsvTable object
        /// </summary>
        /// <param name="inputStream"></param>
        /// <param name="fileName"></param>
        /// <param name="containsHeader"></param>
        /// <returns></returns>
        CsvHandleResult ParseCsvFile(Stream inputStream, string fileName, bool containsHeader);
    }
}
