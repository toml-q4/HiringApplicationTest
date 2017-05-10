using System.IO;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;
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
        ///

        public CsvTable ParseCsv(string fileContent, bool containsHeader)
        {
            CsvTable CsvContent = new CsvTable();
            CsvRow eachRow = new CsvRow();
            
            string line = null;
        
            StringReader strReader = new StringReader(fileContent);
            while (true)
            {
                line = strReader.ReadLine();
                string[] tokens = line.Split(',');
                for(int i=0; i <tokens.Length; i++)
                {
                    CsvColumn column = new CsvColumn(tokens[i]);
                    eachRow.Columns.Add(column);
                }
               
            }

            
            return null;

        }
    }
}
