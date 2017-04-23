//TODO
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Q4CsvParser.Core.Tests
//{
//    [TestClass]
//    public class ValidationServiceTest
//    {
//        // please note that I initialize the service directly
//        // because I know the implementation I want to test

//        // in some cases, you might not want to do this
//        [TestMethod]
//        public void TestIsCSVFile_ValidFile()
//        {
//            bool expectedResult = true;
//            var validationService = new ValidationService();

//            bool actualResult = validationService.IsCsvFile(@"C:\test.csv");
//            Assert.AreEqual<bool>(expectedResult, actualResult);
//        }

//        [TestMethod]
//        public void TestIsCSVFile_InvalidFile()
//        {
//            bool expectedResult = false;
//            var validationService = new ValidationService();

//            bool actualResult = validationService.IsCsvFile(@"C:\test.txt");
//            Assert.AreEqual<bool>(expectedResult, actualResult);
//        }


//        [TestMethod]
//        public void TestIsCSVFile_EmptyFilePath()
//        {
//            bool expectedResult = false;
//            var validationService = new ValidationService();

//            bool actualResult = validationService.IsCsvFile(string.Empty);
//            Assert.AreEqual<bool>(expectedResult, actualResult);
//        }

//        [TestMethod]
//        public void TestIsCSVFile_NullFilePath()
//        {
//            bool expectedResult = false;
//            var validationService = new ValidationService();

//            bool actualResult = validationService.IsCsvFile(null);
//            Assert.AreEqual<bool>(expectedResult, actualResult);
//        }

//        [TestMethod]
//        public void TestIsCSVFile_GrabageFilePath()
//        {
//            bool expectedResult = false;
//            var validationService = new ValidationService();

//            bool actualResult = validationService.IsCsvFile("asdasd");
//            Assert.AreEqual<bool>(expectedResult, actualResult);
//        }
//    }
//}
