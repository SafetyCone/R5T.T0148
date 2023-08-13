using System;
using System.Text;

using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.T0148
{
	[DraftFunctionalityMarker]
	public partial interface ILoggerOperator : IDraftFunctionalityMarker
	{
        public void AppendLogMessageTextWithLogLevel(
            StringBuilder logBuilder,
            LogLevel logLevel, string logName, int eventId, string message, Exception exception)
        {
            var logLevelString = Instances.LogLevelOperator.GetLogLevelShortName(logLevel);

            logBuilder.Append(logLevelString);

            this.AppendLogMessageTextWithoutLogLevel(logBuilder,
                logName, eventId, message, exception);
        }

        public void AppendLogMessageTextWithoutLogLevel(
            StringBuilder logBuilder,
            string logName, int eventId, string message, Exception exception)
        {
            // Category and Event ID. Example:
            //
            // INFO: ConsoleApp.Program[10]
            //       Request received

            var logLevelPadding = ": ";

            logBuilder.Append(logLevelPadding)
                .Append(logName)
                .Append(Instances.Characters.OpenBracket_Correct)
                .Append(eventId)
                .Append(Instances.Characters.CloseBracket_Correct)
                .AppendLine()
                ;

            // Message
            if (F0000.StringOperator.Instance.IsNotNullAndNotEmpty(message))
            {
                var messageTabinationCount = 6;
                var messageTabination = new String(Instances.Characters.Space, messageTabinationCount);

                logBuilder.Append(messageTabination);

                // Indent all new lines in the message.
                var length = logBuilder.Length;

                logBuilder.AppendLine(message);
                logBuilder.Replace(Environment.NewLine, Environment.NewLine + messageTabination, length, message.Length);
            }

            // Exception message. Example:
            //
            // System.InvalidOperationException
            //    at Namespace.Class.Function() in File:line X

            if (exception != null)
            {
                logBuilder.AppendLine(exception.ToString());
            }
        }

        /// <summary>
        /// Chooses <see cref="GetLogMessageTextWithLogLevel(LogLevel, string, int, string, Exception)"/> as the default.
        /// </summary>
        public string GetLogMessageText(
            LogLevel logLevel, string logName, int eventId, string message, Exception exception)
        {
            var output = this.GetLogMessageTextWithLogLevel(
                logLevel, logName, eventId, message, exception);

            return output;
        }

        public string GetLogMessageTextWithLogLevel(
            LogLevel logLevel, string logName, int eventId, string message, Exception exception)
        {
            var output = new StringBuilder()
                .GetString(logBuilder =>
                {
                    this.AppendLogMessageTextWithLogLevel(logBuilder,
                        logLevel, logName, eventId, message, exception);
                });

            return output;
        }
    }
}