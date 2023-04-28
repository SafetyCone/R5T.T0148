using System;
using System.Threading.Tasks;

using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.T0148
{
    [FunctionalityMarker]
    public partial interface ILoggingOperator : IFunctionalityMarker
    {
        public ILogger Get_Logger(
            string categoryName,
            string logFilePath)
        {
            // No using, keep reference and return.
            var serviceProvider = Instances.ServicesOperator.GetFileLoggerServiceProvider(
                logFilePath);

            var logger = Instances.ServicesOperator.GetLogger(
                serviceProvider,
                categoryName);

            var output = new LoggerWithServiceProvider(logger, serviceProvider);
            return output;
        }

        public void InFileLoggerContext_Synchronous<T>(
            string logFilePath,
            Action<ILogger> loggerAction)
        {
            using var serviceProvider = Instances.ServicesOperator.GetFileLoggerServiceProvider(
                logFilePath);

            var logger = Instances.ServicesOperator.GetLogger<T>(serviceProvider);

            loggerAction(logger);
        }

        public void InFileLoggerContext_Synchronous(
            string categoryName,
            string logFilePath,
            Action<ILogger> loggerAction)
        {
            using var serviceProvider = Instances.ServicesOperator.GetFileLoggerServiceProvider(
                logFilePath);

            var logger = Instances.ServicesOperator.GetLogger(
                serviceProvider,
                categoryName);

            loggerAction(logger);
        }

        public Task InFileLoggerContext<T>(
            string logFilePath,
            Func<ILogger, Task> loggerAction)
        {
            using var serviceProvider = Instances.ServicesOperator.GetFileLoggerServiceProvider(
                logFilePath);

            var logger = Instances.ServicesOperator.GetLogger<T>(serviceProvider);

            return loggerAction(logger);
        }

        public async Task InFileLoggerContext(
            string categoryName,
            string logFilePath,
            Func<ILogger, Task> loggerAction)
        {
            using var serviceProvider = Instances.ServicesOperator.GetFileLoggerServiceProvider(
                logFilePath);

            var logger = Instances.ServicesOperator.GetLogger(
                serviceProvider,
                categoryName);

            await loggerAction(logger);
        }
    }
}
