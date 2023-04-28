using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;


namespace R5T.T0148
{
    /// <summary>
    /// Allows returning a <see cref="ILogger"/> instance, that keeps a reference to the <see cref="ServiceProvider"/> it was generated from.
    /// This allows the <see cref="ILogger"/> instance to be indepdenent.
    /// </summary>
    public class LoggerWithServiceProvider : ILogger, IDisposable
    {
        private ILogger Logger { get; }
        private ServiceProvider ServiceProvider { get; }


        public LoggerWithServiceProvider(
            ILogger logger,
            ServiceProvider serviceProvider)
        {
            this.Logger = logger;
            this.ServiceProvider = serviceProvider;
        }

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            this.Logger.Log(
                logLevel,
                eventId,
                state,
                exception,
                formatter);
        }

        public bool IsEnabled(LogLevel logLevel)
        {
            return this.Logger.IsEnabled(logLevel);
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            return this.Logger.BeginScope(state);
        }

        public void Dispose()
        {
            this.ServiceProvider.Dispose();
        }
    }
}
