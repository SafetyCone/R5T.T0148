using System;


namespace R5T.T0148
{
	public class LoggerOperator : ILoggerOperator
	{
		#region Infrastructure

	    public static ILoggerOperator Instance { get; } = new LoggerOperator();

	    private LoggerOperator()
	    {
        }

	    #endregion
	}
}