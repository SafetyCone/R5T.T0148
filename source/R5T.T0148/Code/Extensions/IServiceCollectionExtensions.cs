using System;

using Microsoft.Extensions.DependencyInjection;


namespace R5T.T0148
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddFileLoggerProvider(this IServiceCollection services,
            string logFilePath)
        {
            return ServiceCollectionOperator.Instance.AddFileLoggerProvider(services, logFilePath);
        }
    }
}
