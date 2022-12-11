using AutoMapper;
using ClashTracker.Shared.Models.ApiResponse;
using ClashTracker.Shared.Models.Badge;

namespace ClashTracker.Client.Profiles
{
    public class BadgeProfile : Profile
    {
        public BadgeProfile()
        {
            CreateMap<ApiResponseClanModel.BadgeUrlReadModel, BadgeUrlReadModel>();
        }
    }
}
