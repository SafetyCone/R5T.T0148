using System;


namespace R5T.T0148
{
    public class LogFilePathOperator : ILogFilePathOperator
    {
        #region Infrastructure

        public static ILogFilePathOperator Instance { get; } = new LogFilePathOperator();


        private LogFilePathOperator()
        {
        }

        #endregion
    }
}
