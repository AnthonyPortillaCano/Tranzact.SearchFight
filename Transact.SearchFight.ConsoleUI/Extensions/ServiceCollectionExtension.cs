using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Transact.SearchFight.Infraestructure.Models.Config;
using Transact.SearchFight.Infraestructure.Repository;
using Tranzact.SearchFight.ApplicationCore.Interfaces;
using Tranzact.SearchFight.ApplicationCore.Services;

namespace Transact.SearchFight.ConsoleUI.Extensions
{
    /// <summary>
    /// ServiceCollection extension pattern
    /// </summary>
    public static class ServiceCollectionExtension
    {
        /// <summary>
        /// Register search engines configuration
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns><see cref="IServiceCollection"/> services </returns>
        public static IServiceCollection AddConfiguration(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<GoogleConfig>(configuration.GetSection($"SearchEngines:GoogleConfig"));
            services.Configure<BingConfig>(configuration.GetSection($"SearchEngines:BingConfig"));
            return services;
        }
        /// <summary>
        /// Register DI for repository objects
        /// </summary>
        /// <param name="services"></param>
        /// <returns><see cref="IServiceCollection"/> services </returns>
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddTransient<ISearchRepository, GoogleSearchRepository>();
            services.AddTransient<ISearchRepository, BingSearchRespository>();
            return services;
        }

        /// <summary>
        /// Register DI for service objects
        /// </summary>
        /// <param name="services"></param>
        /// <returns><see cref="IServiceCollection"/> services </returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddTransient<ISearchService, SearchService>();
            services.AddTransient<IWinnerService, WinnerService>();
            services.AddTransient<IReportService, ReportService>();
            return services;
        }
    }
}
