using AutoMapper;
using ClashTracker.Shared.Models.ApiResponse;
using ClashTracker.Shared.Models.Icon;

namespace ClashTracker.Client.Profiles
{
    public class IconProfile : Profile
    {
        public IconProfile()
        {
            CreateMap<ApiResponseClanModel.IconUrlReadModel, IconUrlReadModel>();
        }
    }
}
