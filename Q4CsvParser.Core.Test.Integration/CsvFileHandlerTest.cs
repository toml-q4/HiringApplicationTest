using NUnit.Framework;

namespace Q4CsvParser.Core.Test.Integration
{
    /// <summary>
    /// Bonus Task:
    /// We've provided a few testing files. Integration test the csv file handler using these files.
    /// Feel free to use any testing framework you desire. (i.e. NUnit, XUnit, Microsoft built-in testing framework)
    /// </summary>
    public class CsvFileHandlerTest
    {
        private const string JunkFileName = "junk.txt";
        private const string HeaderBlankLinesFileName = "sample.with.header.blank.lines.csv";
        private const string HeaderFileName = "sample.with.header.csv";
        private const string HeaderMissingFieldsFileName = "sample.with.header.missing.fields.csv";
        private const string NoHeaderThreeRowsFileName = "sample.without.header.3.rows.csv";
        private const string NoHeaderFileName = "sample.without.header.csv";

        private string GetFilePath(string fileName)
        {
            return $@"..\..\TestFiles\{fileName}";
        }

        int i = 0;
        //TODO integration test the CsvFileHandler here

      
        
    }


    [TestFixture]
    public class CSVFileHandlerTest2
    {
        //CSVFile ;
        //Account destination;

        //[SetUp]
        //public void Init()
        //{
        //    source = new Account();
        //    source.Deposit(200m);

        //    destination = new Account();
        //    destination.Deposit(150m);
        //}

        [Test]
        public void LoadFile()
        {
        //    source.TransferFunds(destination, 100m);

        //    Assert.AreEqual(250m, destination.Balance);
        //    Assert.AreEqual(100m, source.Balance);
        }

        //[Test]
        //[ExpectedException(typeof(InsufficientFundsException))]
        //public void TransferWithInsufficientFunds()
        //{
        //    source.TransferFunds(destination, 300m);
        //}

        //[Test]
        //[Ignore("Decide how to implement transaction management")]
        //public void TransferWithInsufficientFundsAtomicity()
        //{
        //    try
        //    {
        //        source.TransferFunds(destination, 300m);
        //    }
        //    catch (InsufficientFundsException expected)
        //    {
        //    }

        //    Assert.AreEqual(200m, source.Balance);
        //    Assert.AreEqual(150m, destination.Balance);
        //}
    }

   
}



