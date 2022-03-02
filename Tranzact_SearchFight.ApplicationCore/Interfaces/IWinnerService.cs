using Tranzact.SearchFight.ApplicationCore.Models;

namespace Tranzact.SearchFight.ApplicationCore.Interfaces
{
    /// <summary>
    /// Winner service interface
    /// </summary>
    public interface IWinnerService
    {
        /// Get winners by search engine.
        List<Search> GetWinnerBySearchEngine(List<Search> searchData);

        /// Get total search winner.
        string GetTotalWinner(List<Search> searchData);
    }
}
