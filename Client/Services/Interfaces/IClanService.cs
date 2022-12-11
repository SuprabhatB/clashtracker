using ClashTracker.Client.Models.ClientResponse;
using ClashTracker.Shared.Models.Clan;
using System.Threading.Tasks;

namespace ClashTracker.Client.Services.Interfaces
{
    public interface IClanService
    {
        /// <summary>
        /// Gets the clan by name asynchronous.
        /// </summary>
        /// <param name="clanSearch">The clan search.</param>
        /// <returns></returns>
        Task<ClientResponseResultModel<ClanReadModel>> GetClanByNameAsync(ClanSearchModel clanSearch);

        /// <summary>
        /// Gets the clan by tag asynchronous.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        Task<ClientResponseResultModel<ClanReadModel>> GetClanByTagAsync(string name);
    }
}
