using System;

using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.T0148
{
	[FunctionalityMarker]
	public partial interface ILoggingBuilderOperator : IFunctionalityMarker
	{
        public ILoggingBuilder AddFile(ILoggingBuilder loggingBuilder,
            string logFilePath)
        {
            loggingBuilder.Services.AddFileLoggerProvider(logFilePath);

            return loggingBuilder;
        }
    }
}