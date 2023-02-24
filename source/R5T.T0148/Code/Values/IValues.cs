using System;

using R5T.T0131;


namespace R5T.T0148
{
    [ValuesMarker]
    public partial interface IValues : IValuesMarker
    {
        public string DefaultApplicationName => "Log";
    }
}
