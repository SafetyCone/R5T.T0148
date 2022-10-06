using System;

using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.T0148
{
	[DraftFunctionalityMarker]
	public partial interface ILogLevelOperator : IDraftFunctionalityMarker
	{
        public string GetLogLevelShortName(LogLevel logLevel)
        {
            var output = logLevel switch
            {
                LogLevel.Trace => Instances.LogLevelNames.Trace_Short,
                LogLevel.Debug => Instances.LogLevelNames.Debug_Short,
                LogLevel.Information => Instances.LogLevelNames.Information_Short,
                LogLevel.Warning => Instances.LogLevelNames.Warning_Short,
                LogLevel.Error => Instances.LogLevelNames.Error_Short,
                LogLevel.Critical => Instances.LogLevelNames.Critical_Short,
                _ => throw F0000.EnumerationOperator.Instance.SwitchDefaultCaseException(logLevel),
            };

            return output;
        }
    }
}