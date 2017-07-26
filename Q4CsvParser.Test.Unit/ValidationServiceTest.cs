using NUnit.Framework;
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
    [TestFixture]
    public class ValidationServiceTest
    {
        //TODO unit test the ValidationService here
        [Test]
        public void IsCsvFile_Csvfile_ReturnsTrue()
        {
            var validationService = new ValidationService();
            var result = validationService.IsCsvFile("test.csv");

            Assert.IsTrue(result, "Should return true for csv files");
        }

        [Test]
        public void IsCsvFile_NonCsvfile_ReturnsFalse()
        {
            var validationService = new ValidationService();
            var result = validationService.IsCsvFile("test.txt");

            Assert.IsFalse(result, "Should return false for non-csv files");
        }
    }
}
