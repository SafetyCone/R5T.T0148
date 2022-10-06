using System;


namespace R5T.T0148
{
	public class LogLevelOperator : ILogLevelOperator
	{
		#region Infrastructure

	    public static ILogLevelOperator Instance { get; } = new LogLevelOperator();

	    private LogLevelOperator()
	    {
        }

	    #endregion
	}
}