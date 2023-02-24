using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.T0148
{
    [FunctionalityMarker]
    public partial interface IServicesOperator : IFunctionalityMarker,
        F0035.F001.IServicesOperator
    {
        public ServiceProvider GetFileLoggerServiceProvider(
            string logFilePath)
        {
            var services = new ServiceCollection()
                .AddLogging(loggingBuilder =>
                {
                    loggingBuilder
                        .SetMinimumLevel(LogLevel.Debug)
                        .AddFile(logFilePath)
                        ;
                })
                ;

            var serviceProvider = services.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
