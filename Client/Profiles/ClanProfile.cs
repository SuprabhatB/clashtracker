using AutoMapper;
using ClashTracker.Client.Models.Clan;
using ClashTracker.Shared.Models.ApiResponse;
using ClashTracker.Shared.Models.Clan;

namespace ClashTracker.Client.Profiles
{
    public class ClanProfile : Profile
    {
        public ClanProfile()
        {
            CreateMap<ApiResponseClanModel.ClanReadModel, ClanReadModel>()
                .ForMember(dest => dest.Badge, opt => opt.MapFrom(src => src.BadgeUrls));

            CreateMap<ClanSearchFormModel, ClanSearchModel>()
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.SearchTerm.Trim()));
        }
    }
}