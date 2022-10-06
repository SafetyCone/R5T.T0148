using System;
using System.IO;

using Microsoft.Extensions.Logging;

using R5T.T0142;


namespace R5T.T0148
{
    [UtilityTypeMarker]
    public sealed class FileLoggerProvider : ILoggerProvider
    {
        #region Static

        private static void PerformFirstTimeSetup(FileLoggerProvider fileLoggerProvider)
        {
            F0000.FileSystemOperator.Instance.EnsureDirectoryForFilePathExists(fileLoggerProvider.LogFilePath);

            fileLoggerProvider.TextWriter = new StreamWriter(fileLoggerProvider.LogFilePath);
        }

        private static void EnsureIsSetup(FileLoggerProvider fileLoggerProvider)
        {
            var isSetup = fileLoggerProvider.TextWriter is object;
            if (!isSetup)
            {
                FileLoggerProvider.PerformFirstTimeSetup(fileLoggerProvider);
            }
        }

        #endregion

        #region IDisposable

        private bool Disposed = false;


        public void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.Disposed)
            {
                if (disposing)
                {
                    this.TextWriter.Dispose();
                }

                this.Disposed = true;
            }
        }

        ~FileLoggerProvider()
        {
            this.Dispose(disposing: false);
        }

        #endregion


        public string LogFilePath { get; }
        public TextWriter TextWriter { get; private set; }


        public FileLoggerProvider(string logFilePath)
        {
            this.LogFilePath = logFilePath;
        }

        public ILogger CreateLogger(string categoryName)
        {
            FileLoggerProvider.EnsureIsSetup(this);

            var output = new FileLogger(
                categoryName,
                this);

            return output;
        }
    }
}