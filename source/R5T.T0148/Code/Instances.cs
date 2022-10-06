using System;

using R5T.Z0000;


namespace R5T.T0148
{
    public static class Instances
    {
        public static ICharacters Characters { get; } = Z0000.Characters.Instance;
        public static ILoggerOperator LoggerOperator { get; } = T0148.LoggerOperator.Instance;
        public static ILogLevelNames LogLevelNames { get; } = T0148.LogLevelNames.Instance;
        public static ILogLevelOperator LogLevelOperator { get; } = T0148.LogLevelOperator.Instance;
    }
}