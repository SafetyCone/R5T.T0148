using System;


namespace R5T.T0148
{
    public static class Instances
    {
        public static Z0000.ICharacters Characters => Z0000.Characters.Instance;
        public static F0000.IDateTimeOperator DateTimeOperator => F0000.DateTimeOperator.Instance;
        public static IDirectoryPaths DirectoryPaths => T0148.DirectoryPaths.Instance;
        public static ILoggerOperator LoggerOperator => T0148.LoggerOperator.Instance;
        public static ILogLevelNames LogLevelNames => T0148.LogLevelNames.Instance;
        public static ILogLevelOperator LogLevelOperator => T0148.LogLevelOperator.Instance;
        public static ILogFileNameOperator LogFileNameOperator => T0148.LogFileNameOperator.Instance;
        public static ILogFilePathOperator LogFilePathOperator => T0148.LogFilePathOperator.Instance;
        public static F0000.INowOperator NowOperator => F0000.NowOperator.Instance;
        public static F0002.IPathOperator PathOperator => F0002.PathOperator.Instance;
        public static IServicesOperator ServicesOperator => T0148.ServicesOperator.Instance;
        public static IValues Values => T0148.Values.Instance;
    }
}