using System;


namespace R5T.T0148
{
	public class LogLevelNames : ILogLevelNames
	{
		#region Infrastructure

	    public static ILogLevelNames Instance { get; } = new LogLevelNames();

	    private LogLevelNames()
	    {
        }

	    #endregion
	}
}