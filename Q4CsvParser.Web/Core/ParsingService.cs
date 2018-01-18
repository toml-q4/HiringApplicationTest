using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.FileIO;
using Q4CsvParser.Contracts;
using Q4CsvParser.Domain;

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
            var csvTable = new CsvTable();

            try {
                string[] entries = fileContent.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var start = 0;
                if (containsHeader)
                {
                    var list = new List<CsvColumn>();
                    var header = entries[0].Split(',');
                    foreach (var item in header)
                    {
                        list.Add(new CsvColumn(item));
                    }
                    csvTable.HeaderRow = new CsvRow() { Columns = list };
                    start = 1;
                }


                for (int i = start; i < entries.Length; i++)
                {
                    var list = new List<CsvColumn>();
                    var entry = entries[i].Split(',');
                    foreach (var item in entry)
                    {
                        list.Add(new CsvColumn(item));
                    }
                    csvTable.Rows.Add(new CsvRow() { Columns = list });
                }                
            }
            catch (Exception) {
                return null;
            }          


            return csvTable;


        }
    }
}
