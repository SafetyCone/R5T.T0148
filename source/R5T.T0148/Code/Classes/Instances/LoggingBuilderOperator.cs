using System;


namespace R5T.T0148
{
	public class LoggingBuilderOperator : ILoggingBuilderOperator
	{
		#region Infrastructure

	    public static ILoggingBuilderOperator Instance { get; } = new LoggingBuilderOperator();

	    private LoggingBuilderOperator()
	    {
        }

	    #endregion
	}
}