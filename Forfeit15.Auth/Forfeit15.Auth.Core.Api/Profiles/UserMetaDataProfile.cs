using AutoMapper;
using Forfeit15.Auth.Core.Api.Services.UserMetaData;
using Forfeit15.Postgres.Models.UserMetaData;

namespace Forfeit15.Auth.Core.Api.Profiles;

public class UserMetaDataProfile : Profile
{
    public UserMetaDataProfile()
    {
        CreateMap<UserMetaData, UserMetaDataViewmodel>().ReverseMap();
    }
}