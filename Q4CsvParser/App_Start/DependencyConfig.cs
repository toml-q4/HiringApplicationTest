using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using Q4CsvParser.CompositionRoot;
using Q4CsvParser.Controllers;

namespace Q4CsvParser.App_Start
{
    public static class DependencyConfig
    {
        public static void RegisterDependencies()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<GeneralModule>();
            builder.RegisterControllers(typeof(HomeController).Assembly);

            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}