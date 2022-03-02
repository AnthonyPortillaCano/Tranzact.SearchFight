using Tranzact.SearchFight.ApplicationCore.Models;

namespace Tranzact.SearchFight.ApplicationCore.Interfaces
{
    /// <summary>
    /// Report service interface
    /// </summary>
    public interface IReportService
    {
        /// <summary>
        /// Get search fight result
        /// </summary>
        /// <param name="args"></param>
        /// <returns><see cref="SearchReport"/></returns>
        Task<SearchReport> ExecuteSearchFightAsync(List<string> args);
    }
}
