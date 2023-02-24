using System;


namespace R5T.T0148
{
    public class ServicesOperator : IServicesOperator
    {
        #region Infrastructure

        public static IServicesOperator Instance { get; } = new ServicesOperator();


        private ServicesOperator()
        {
        }

        #endregion
    }
}
