using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;


namespace R5T.D0047.Default.Code.Extensions
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="HardCodedCommonValueProvider"/> implementation of <see cref="ICommonValueProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddHardCodedCommonValueProvider(this IServiceCollection services)
        {
            services.AddSingleton<ICommonValueProvider, HardCodedCommonValueProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="HardCodedCommonValueProvider"/> implementation of <see cref="ICommonValueProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<ICommonValueProvider> AddHardCodedCommonValueProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<ICommonValueProvider>(() => services.AddHardCodedCommonValueProvider());
            return serviceAction;
        }
    }
}
