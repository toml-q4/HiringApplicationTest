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
    public class ParsingServiceTest
    {
        //TODO Unit test the ParsingService here
        [Test]
        public void ParseCsv_EmptyStringInput_GivesZeroRows()
        {
            ParsingService parseService = new ParsingService();
            var result = parseService.ParseCsv("", false);

            Assert.IsEmpty(result.Rows);
        }

        [Test]
        public void ReadRow_EmptyStringInput_GivesZeroRows()
        {
            ParsingService parseService = new ParsingService();
            var result = parseService.ReadRow("");

            Assert.IsEmpty(result.Columns);
        }
    }
}
