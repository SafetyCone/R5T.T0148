using System;

using Microsoft.Extensions.Logging;

using R5T.T0142;

using R5T.T0148.Internal;


namespace R5T.T0148
{
    [UtilityTypeMarker]
    public class FileLogger : LoggerBase
    {
        private FileLoggerProvider FileLoggerProvider { get; }


        public FileLogger(
            string categoryName,
            FileLoggerProvider fileLoggerProvider)
            : base(categoryName)
        {
            this.FileLoggerProvider = fileLoggerProvider;
        }

        public override void WriteMessage(LogLevel logLevel, string logName, int eventId, string message, Exception exception)
        {
            var messageText = Instances.LoggerOperator.GetLogMessageText(
                logLevel, logName, eventId, message, exception);

            // Use Write() not WriteLine() to allow caller to fully handle newline behavior.
            this.FileLoggerProvider.TextWriter.Write(messageText);
            this.FileLoggerProvider.TextWriter.Flush(); // Immediately flush.
        }
    }
}
