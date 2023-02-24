using System;


namespace R5T.T0148
{
    public class LoggingOperator : ILoggingOperator
    {
        #region Infrastructure

        public static ILoggingOperator Instance { get; } = new LoggingOperator();


        private LoggingOperator()
        {
        }

        #endregion
    }
}
