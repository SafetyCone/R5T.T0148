using System;

using R5T.T0132;


namespace R5T.T0148
{
    [FunctionalityMarker]
    public partial interface ILogFileNameOperator : IFunctionalityMarker
    {
        public string GetLogFileName(
            string applicationName,
            DateTime dateTime)
        {
            var dateTimeToken = Instances.DateTimeOperator.ToString_YYYYMMDD_HHMMSS(dateTime);

            var output = $"{applicationName}-{dateTimeToken}.log";
            return output;
        }

        public string GetLogFileName(
            string applicationName)
        {
            var dateTime = Instances.NowOperator.GetNow();

            var output = this.GetLogFileName(
                applicationName,
                dateTime);

            return output;
        }

        public string GetLogFileName()
        {
            var applicationName = Instances.Values.DefaultApplicationName;

            var output = this.GetLogFileName(
                applicationName);

            return output;
        }
    }
}
