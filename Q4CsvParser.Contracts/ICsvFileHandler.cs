using System.Web;
using Q4CsvParser.Domain;

namespace Q4CsvParser.Contracts
{
    public interface ICsvFileHandler
    {
        /// <summary>
        /// Takes in an input stream from HttpPostedFileBase and returns a parsed CsvTable object
        /// </summary>
        /// <param name="inputFile"></param>
        /// <param name="fileName"></param>
        /// <param name="containsHeader"></param>
        /// <returns></returns>
        CsvHandleResult ParseCsvFile(HttpPostedFileBase inputFile, string fileName, bool containsHeader);
    }
}
