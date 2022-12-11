using AutoMapper;
using ClashTracker.Shared.Models.ApiResponse;

namespace ClashTracker.Client.Profiles
{
    public class LabelProfile : Profile
    {
        public LabelProfile()
        {
            CreateMap<ApiResponseClanModel.LabelReadModel, ApiResponseClanModel.LabelReadModel>();
        }
    }
}
