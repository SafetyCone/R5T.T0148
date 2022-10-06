using System;

using R5T.T0131;


namespace R5T.T0148
{
    /// <summary>
    /// See: https://github.com/aspnet/Logging/blob/2d2f31968229eddb57b6ba3d34696ef366a6c71b/src/Microsoft.Extensions.Logging.Console/ConsoleLogger.cs#L227
    /// </summary>
	[DraftValuesMarker]
	public partial interface ILogLevelNames : IDraftValuesMarker
	{
        public string None => "none";

        public string Trace_Short => "trce";
        public string Debug_Short => "dbug";
        public string Information_Short => "info";
        public string Warning_Short => "warn";
        public string Error_Short => "fail";
        public string Critical_Short => "crit";
    }
}