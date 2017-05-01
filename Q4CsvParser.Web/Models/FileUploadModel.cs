using System.Web;

namespace Q4CsvParser.Web.Models
{
    public class FileUploadModel
    {
        public HttpPostedFileBase File { get; set; }
        public bool ContainsHeader { get; set; }
    }
}