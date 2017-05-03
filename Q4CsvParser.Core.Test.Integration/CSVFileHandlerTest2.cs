//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using NUnit.Framework;

//namespace Q4CsvParser.Core.Test.Integration
//{
    
//    [TestFixture]
//    public class CSVFileHandlerTest
//    {
//        [Test]
//        public void TransferFunds()
//        {
//            CSVFileHandler Account source = new Account();
//            source.Deposit(200m);

//            Account destination = new Account();
//            destination.Deposit(150m);

//            source.TransferFunds(destination, 100m);

//            Assert.AreEqual(250m, destination.Balance);
//            Assert.AreEqual(100m, source.Balance);
//        }
//    }
//}
