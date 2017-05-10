using System;
using Q4CsvParser.Web.Core;

namespace Q4CsvParser.Test.Unit
{
    /// <summary>
    /// This class should have content. 
    /// Feel free to use any testing framework you desire. (i.e. NUnit, XUnit, Microsoft built-in testing framework)
    /// You may also use a mocking framework (i.e. Moq, RhinoMock)
    /// 
    /// If you've never done unit testing before, don't worry about this section and look to complete some of the bonus mark tasks
    /// </summary>
    public class ValidationServiceTest
    {
        string testFileName = "C:\\inetpub\\Q4Web-HiringApplicationTest-master\\Q4CsvParser.Test.Integration\\TestFiles\\sample.with.header.blank.lines.csv";
        ValidationService ValidClass = new ValidationService();
        public void isValidCsvFormat()
        {
            if (ValidClass.IsCsvFile(testFileName))
            {
                Console.WriteLine("The file is a .csv format and the file name is {0}", testFileName);

            }
            else
            {
                Console.WriteLine("The file is not a csv file");

            }

        }


    }
}
