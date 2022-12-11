using AutoMapper;
using ClashTracker.Shared.Models.ApiResponse;
using ClashTracker.Shared.Models.Language;

namespace ClashTracker.Client.Profiles
{
    public class ChatLanguageProfile : Profile
    {
        public ChatLanguageProfile()
        {
            CreateMap<ApiResponseClanModel.ChatLanguageReadModel, ChatLanguageReadModel>();
        }
    }
}
