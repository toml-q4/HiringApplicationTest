using System;
using Q4CsvParser.Core.Contracts;
using Q4CsvParser.Domain;
using System.Collections.Generic;

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
            string[] Fields; 
            Fields = fileContent.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
            CsvTable csvTable = new CsvTable();

            var firstHeader = Fields[0].Split(new char[] { ',' });
            var headerRowColumns = new List<CsvColumn>();
            for (int i = 0; i < firstHeader.Length; i++)
            {
                headerRowColumns.Add( new CsvColumn(firstHeader[i]));
            }
            var headerRow = new CsvRow();
            headerRow.Columns = headerRowColumns;
            csvTable.HeaderRow = headerRow;
            for (int i = 2; i < Fields.Length; i++)
            {
                var rowData = Fields[i].Split(new char[] { ',' });
                var rowColumnData = new List<CsvColumn>();
                for (int f = 0; f < rowData.Length; f++)
                {
                    rowColumnData.Add(new CsvColumn(rowData[f]));
                }
                csvTable.Rows.Add(new CsvRow()
                {
                    Columns = rowColumnData
                });
            }
            return csvTable;
        
    }
    }
}
