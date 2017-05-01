using log4net;
using Q4CsvParser.Core;
using Q4CsvParser.Core.Contracts;
using Q4CsvParser.Domain;
using Q4CsvParser.Web.Models;
using System.Web;
using System.Web.Mvc;

namespace Q4CsvParser.Web.Controllers
{
    /// <summary>
    /// This file does not need to be unit tested. You shouldn't need to modify this.
    /// Bonus Task:
    /// Use your favourite dependency injection framework (i.e. Autofac, Ninject) to inject all the services.
    /// This project uses MVC5 so make sure you grab the right implementation. 
    /// Bonus Task:
    /// Validate the input to the post function on the client side. You can use javascript or Razor syntax, 
    ///  but don't use any 3rd party code for this.
    /// </summary>
    public class FileUploadController : Controller
    {
        private readonly ICsvFileHandler _csvFileHandler;
        private readonly ILog _logger;

        public FileUploadController()
        {
            _csvFileHandler = new CsvFileHandler(new ParsingService(), new ValidationService(), new FileService());
            _logger = LogManager.GetLogger("MvcApplication");
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Error(string errorMessage)
        {
            var model = new ErrorModel { ErrorMessage = errorMessage };
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

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file == null || file.ContentLength <= 0)
                return HandleError("You need to click Choose File first, then Submit.");

            var result = _csvFileHandler.ParseCsvFile(file.InputStream, file.FileName);
            if (!result.Success)
                return HandleError(result.ErrorMessage);

            return RedirectToAction("FormattedDisplay", new { result.ParsedCsvContent, file.FileName });
        }

        private ActionResult HandleError(string errorMessage)
        {
            _logger.Error(errorMessage);
            return RedirectToAction("Error", new { errorMessage });
        }
    }
}