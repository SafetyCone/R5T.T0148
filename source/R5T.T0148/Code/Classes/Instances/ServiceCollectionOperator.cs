using System;


namespace R5T.T0148
{
	public class ServiceCollectionOperator : IServiceCollectionOperator
	{
		#region Infrastructure

	    public static IServiceCollectionOperator Instance { get; } = new ServiceCollectionOperator();

	    private ServiceCollectionOperator()
	    {
        }

	    #endregion
	}
}