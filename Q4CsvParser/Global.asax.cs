using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using log4net.Config;
using Q4CsvParser.App_Start;

namespace Q4CsvParser
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            InitLog4Net();

            AreaRegistration.RegisterAllAreas();

            DependencyConfig.RegisterDependencies();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private static void InitLog4Net() {
            XmlConfigurator.Configure();
        }
    }
}