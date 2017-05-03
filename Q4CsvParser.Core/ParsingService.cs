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
        /// <param name="containsHeader"></param>
        /// <returns></returns>
        public CsvTable ParseCsv(string fileContent, bool containsHeader)
        {
            int columnCount = 0;
            CsvTable csvTable = new CsvTable();
            int i = 0;
            string[] lines = fileContent.Split('\n');
           
            
            foreach (string rowData in lines)
            {
                csvTable.Rows.Add(CreateCSVRow(rowData));
            }

            return csvTable;

        }

        //copy the raw string data in to a CSV Row object
        private CsvRow CreateCSVRow(string rawStringData )
        {            
            CsvRow row = new CsvRow();
            string [] splitData = rawStringData.Split(',');
            
            for(int i=0; i< splitData.Length; i++)
            {
                row.Columns.Add(new CsvColumn(splitData[i].ToString()));
            }

            return row;
        }
    }
}
