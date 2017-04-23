//TODO
//using Microsoft.VisualStudio.TestTools.UnitTesting;

//namespace Q4CsvParser.Core.Tests
//{
//    [TestClass]
//    public class ParsingServiceTest
//    {
//        // please note that I initialize the service directly
//        // because I know the implementation I want to test

//        // in some cases, you might not want to do this

//        [TestMethod]
//        public void ParseCSV_ValidFile_Count()
//        {
//            string testFilePath = GetTestFilePath("sample.without.header.3.rows.csv");
//            int expected = 3;
//            // I would do mocking service here if I am given more time
//            var validationService = new ValidationService();
//            var service = new ParsingService(validationService);

//            var actual = service.ParseCsv(testFilePath);
//            Assert.AreEqual<int>(expected, actual.Count);
//        }

//        [TestMethod]
//        public void ParseCSV_InvalidFile()
//        {
//            string testFilePath = GetTestFilePath("junk.txt");
//            int expected = 0;
//            // I would do mocking service here if I am given more time
//            var validationService = new ValidationService();
//            var service = new ParsingService(validationService);

//            var actual = service.ParseCsv(testFilePath);
//            Assert.AreEqual<int>(expected, actual.Count);
//        }

//        [TestMethod]
//        public void ParseCSV_WithBlankLines()
//        {
//            string testFilePath = GetTestFilePath("sample.with.header.blank.lines.csv");
//            int expected = 3;
//            // I would do mocking service here if I am given more time
//            var validationService = new ValidationService();
//            var service = new ParsingService(validationService);

//            var actual = service.ParseCsv(testFilePath);
//            Assert.AreEqual<int>(expected, actual.Count);
//        }

//        [TestMethod]
//        public void ParseCSV_WithMissingFields()
//        {
//            string testFilePath = GetTestFilePath("sample.with.header.missing.fields.csv");
//            int expected = 4;
//            // I would do mocking service here if I am given more time
//            var validationService = new ValidationService();
//            var service = new ParsingService(validationService);

//            var actual = service.ParseCsv(testFilePath);
//            Assert.AreEqual<int>(expected, actual.Count);
//        }

//        private string GetTestFilePath(string fileName)
//        {
//            return string.Format(@"..\..\TestFiles\{0}", fileName);
//        }
//    }
//}
