using System.IO;
using Q4CsvParser.Domain;

namespace Q4CsvParser.Core.Contracts
{
    public interface ICsvFileHandler
    {
        CsvHandleResult ParseCsvFile(Stream inputStream, string fileName);
    }
}
