using System;

using Microsoft.Extensions.Logging;


namespace R5T.T0148
{
    public static class ILoggingBuilderExtensions
    {
        public static ILoggingBuilder AddFile(this ILoggingBuilder loggingBuilder,
            string logFilePath)
        {
            return LoggingBuilderOperator.Instance.AddFile(loggingBuilder, logFilePath);
        }
    }
}
