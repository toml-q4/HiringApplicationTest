using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;
using Q4CsvParser.Core.Contracts;
using Q4CsvParser.Domain;
using Q4CsvParser.Models;

namespace Q4CsvParser.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICsvFileHandler _csvFileHandler;
        private readonly ILog _logger;

        public HomeController(ICsvFileHandler csvFileHandler, ILog logger)
        {
            _csvFileHandler = csvFileHandler;
            _logger = logger;
        }

        #region [ GETs ]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error(string errorMessage)
        {
            var model = new ErrorModel { ErrorMessage = errorMessage};
            return View(model);
        }

        public ActionResult FormattedDisplay(CsvTable csvTable, string fileName)
        {
            if (csvTable?.Rows == null || !csvTable.Rows.Any())
                return HandleError("File failed to parse");
            if (string.IsNullOrWhiteSpace(fileName))
                return HandleError("File name missing");

            var model = new FormattedDisplayModel
            {
                OriginalFileName = fileName,
                CsvTable = csvTable
            };

            return View(model);
        }
        #endregion

        #region [ POSTs ]
        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file == null || file.ContentLength <= 0)
                return HandleError("You need to click Choose File first, then Submit.");

            var result = _csvFileHandler.ParseCsvFile(file.InputStream, file.FileName);
            if (!result.Success)
                return HandleError(result.ErrorMessage);

            return RedirectToAction("FormattedDisplay", new {result.ParsedCsvContent, file.FileName});
        }

        #endregion

        #region [ Helpers ]
        private ActionResult HandleError(string errorMessage)
        {
            _logger.Error(errorMessage);
            return RedirectToAction("Error", new {errorMessage});
        }
        #endregion
    }
}
