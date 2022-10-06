using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;

using R5T.T0132;


namespace R5T.T0148
{
	[FunctionalityMarker]
	public partial interface IServiceCollectionOperator : IFunctionalityMarker
	{
        public IServiceCollection AddFileLoggerProvider(IServiceCollection services,
            string logFilePath)
        {
            services
                .TryAddEnumerable(ServiceDescriptor.Singleton<ILoggerProvider, FileLoggerProvider>(_ => new FileLoggerProvider(logFilePath)))
                ;

            return services;
        }
    }
}