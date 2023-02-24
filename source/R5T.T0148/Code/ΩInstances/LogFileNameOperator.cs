using System;


namespace R5T.T0148
{
    public class LogFileNameOperator : ILogFileNameOperator
    {
        #region Infrastructure

        public static ILogFileNameOperator Instance { get; } = new LogFileNameOperator();


        private LogFileNameOperator()
        {
        }

        #endregion
    }
}
