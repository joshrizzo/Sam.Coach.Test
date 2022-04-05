using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Sam.Coach.Tests")]

namespace Sam.Coach
{
    public static class Startup
    {
        public static IServiceCollection Configure(IServiceCollection services = null)
        {
            services = services ?? new ServiceCollection();

            services.AddSingleton<ILongestRisingSequenceFinder, LongestRisingSequenceFinder>();

            return services;
        }
    }
}