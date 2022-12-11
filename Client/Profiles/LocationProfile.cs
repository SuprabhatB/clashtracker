using AutoMapper;
using ClashTracker.Shared.Models.ApiResponse;
using ClashTracker.Shared.Models.Location;

namespace ClashTracker.Client.Profiles
{
    public class LocationProfile : Profile
    {
        public LocationProfile()
        {
            CreateMap<ApiResponseClanModel.LocationReadModel, LocationReadModel>();
        }
    }
}
