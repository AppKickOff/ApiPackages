using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ApiPackages.Handlers
{
    public static class IocExtensions
    {
        /// <summary>
        /// Add handlers to a project
        /// </summary>
        /// <param name="services">The services collection to add handlers too</param>
        /// <typeparam name="TAssemblyMarker">An assembly marker</typeparam>
        /// <returns></returns>
        public static IServiceCollection AddHandlers<TAssemblyMarker>(this IServiceCollection services)
        {
            services.AddMediatR(options => options.AsSingleton(), typeof(TAssemblyMarker));
            return services;
        }
    }
}
