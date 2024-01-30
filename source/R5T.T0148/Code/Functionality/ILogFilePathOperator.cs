using System;

using R5T.T0132;


namespace R5T.T0148
{
    [FunctionalityMarker]
    public partial interface ILogFilePathOperator : IFunctionalityMarker
    {
        public string GetLogFilePath()
        {
            var directoryPath = Instances.DirectoryPaths.TempLogsDirectoryPath;

            var fileName = Instances.LogFileNameOperator.GetLogFileName();

            var output = Instances.PathOperator.Get_FilePath(
                directoryPath,
                fileName);

            return output;
        }
    }
}
