using System;
using Q4CsvParser.Contracts;
using Q4CsvParser.Domain;
using System.IO;

namespace Q4CsvParser.Web.Core
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
        /// <param name="containsHeader"></param>
        /// <returns></returns>
        public CsvTable ParseCsv(string fileContent, bool containsHeader)
        {
            //TODO fill in your logic here
            var fileHeaderRead = false;
            var csvTable = new CsvTable();
            //Try to parse each line from the string and save it to csvrow -> csvcolumn
            using (StringReader reader = new StringReader(fileContent))
            {
                string line;
                
                while ((line = reader.ReadLine()) != null)
                {
                    if (containsHeader && !fileHeaderRead)
                    {
                        var header = ReadHeader(line);
                        csvTable.HeaderRow = header;
                        fileHeaderRead = true;
                        continue;
                    }
                    var row = ReadRow(line);
                    if (row != null && row.Columns.Count > 0)
                    {
                        csvTable.Rows.Add(row);
                    }
                }                
            }
            return csvTable;
        }

        private CsvRow ReadHeader(string line)
        {
            return ReadRow(line);
        }

        public CsvRow ReadRow(string line)
        {
            var row = new CsvRow();
            if (String.IsNullOrEmpty(line))
                return row;
            //Get the comma separated values
            char[] delimiterChars = { ',' };
            var values = line.Split(delimiterChars);
            foreach (var value in values)
            {
                var column = new CsvColumn(value);
                row.Columns.Add(column);
            }
            return row;
        }
    }
}
