﻿using System;

using Microsoft.Extensions.Logging;

using R5T.F0000;
using R5T.T0142;


namespace R5T.T0148.Internal
{
    /// <summary>
    /// Logger base implementation that handles boilerplate operations, leaving only the actual message writing up to descendants.
    /// </summary>
    [DraftUtilityTypeMarker]
    public abstract class LoggerBase : ILogger
    {
        protected string CategoryName { get; }


        protected LoggerBase(
            string categoryName)
        {
            this.CategoryName = categoryName;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            // For now, don't support scopes.
            return EmptyDisposable.Instance;
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            // Since the overall logging infrastructure will handle actually obeying filtering rules, this logger can just report true.
            return true;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            // Perform basic boilerplate operations.

            if (!this.IsEnabled(logLevel))
            {
                return;
            }

            if (formatter == null)
            {
                throw new ArgumentNullException(nameof(formatter));
            }

            var message = formatter(state, exception);

            if (F0000.StringOperator.Instance.IsNotNullAndNotEmpty(message) || exception is object)
            {
                this.WriteMessage(logLevel, CategoryName, eventId.Id, message, exception);
            }
        }

        public abstract void WriteMessage(LogLevel logLevel, string logName, int eventId, string message, Exception exception);
    }
}
