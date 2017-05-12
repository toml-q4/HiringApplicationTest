
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Q4CsvParser.Contracts;
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
    [TestClass]
    public class ParsingServiceTest
    {
        //TODO Unit test the ParsingService here
        IParsingService parsing = null;
        [TestInitialize]
        public void InitialiseTest()
        {
           parsing   = new ParsingService();
        }
            [TestMethod]
            public void ParseCSvTest(string filecontent)
        {
            
           
        var csvTable =    parsing.ParseCsv(filecontent, true);
           
            // assert  
            if (csvTable==null)
            {
                throw new System.Exception("File not parsed");
            }
            Assert.AreEqual(true, csvTable);
        }
            
    }
}
