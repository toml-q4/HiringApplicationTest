using Autofac;
using log4net;
using Q4CsvParser.Core;
using Q4CsvParser.Core.Contracts;

namespace Q4CsvParser.CompositionRoot
{
    public class GeneralModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ParsingService>().As<IParsingService>();
            builder.RegisterType<ValidationService>().As<IValidationService>();
            builder.RegisterType<FileService>().As<IFileService>();
            builder.Register(x => LogManager.GetLogger("Q4CsvParser")).As<ILog>();
        }
    }
}
