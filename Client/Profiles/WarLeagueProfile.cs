using AutoMapper;
using ClashTracker.Shared.Models.ApiResponse;
using ClashTracker.Shared.Models.League;

namespace ClashTracker.Client.Profiles
{
    public class WarLeagueProfile:Profile
    {
        public WarLeagueProfile()
        {
            CreateMap<ApiResponseClanModel.WarLeagueReadModel, WarLeagueReadModel>();
        }
    }
}
