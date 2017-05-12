using System;
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
        public CsvTable ParseCsv(string  fileContent, bool containsHeader)
        {
            //TODO fill in your logic here
            // parse the string into csvtable 
            string[] strLInes = { };
            string[] strFields = { };

            string[] strHeader = { };
            CsvTable mCsv = new CsvTable();
            CsvRow mRow = null;
            CsvColumn mCol = null;
           // mCsv.HeaderRow = "";
           if (fileContent!=null && fileContent!="")
            {
                strLInes  = fileContent.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);  //fileContent.Split( ",".ToCharArray());
                // get all the lines in above strlines 
                // get all fields 
                if (containsHeader)
                {
                    // split the header line 
                  strHeader = strLInes[0].Split(new char[] { ',' });
                    mRow = new CsvRow();
                    for (int i = 0; i < strHeader.Length;i ++)
                    {
                        mCol = new CsvColumn(strHeader[i]);
                        mRow.Columns.Add(mCol);
                        
                    }
                    mCsv.Rows.Add(mRow);

                }
                // rest of rows 
                for (int i = 1; i < strLInes.GetLength(0); i++)
                {
                    strFields = strLInes[i].Split(new char[] { ',' });
                    mRow = new CsvRow();
                    for (int j = 0; j < strFields.Length; j++)
                    {
                        mCol = new CsvColumn(strFields[j]);
                        mRow.Columns.Add(mCol);
                    }
                       
                    mCsv.Rows.Add(mRow);
                }
            }

           if(mCsv == null)
            {
                mCsv = new CsvTable(); 

            }
            return mCsv;
        }
    }
}
