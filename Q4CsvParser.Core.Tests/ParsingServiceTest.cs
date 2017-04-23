using System;

namespace Q4CsvParser.Core.Tests
{
    public class ParsingServiceTest
    {
        private static string GetTestFilePath(string fileName)
        {
            return $@"{AppDomain.CurrentDomain.BaseDirectory}\{fileName}";
            
        }
    }
}
