using AutoMapper;
using Forfeit15.Auth.Core.Services.Contracts;

namespace Forfeit15.Auth.Core.Services.UserMetaData.Implementations;

public class UserMetaDataService : IUserMetaDataService
{
    // private readonly UserMetaDataDbContext _userMetaDataDbContext;
    // private readonly IMapper _mapper;
    //
    // public UserMetaDataService(UserMetaDataDbContext userMetaDataDbContext, IMapper mapper)
    // {
    //     _userMetaDataDbContext = userMetaDataDbContext;
    //     _mapper = mapper;
    // }
    //
    // public Task<LoginResponse> AuthenticateUser(UserMetaDataViewmodel userMetaDataViewmodel,
    //     CancellationToken cancellationToken)
    // {
    //     var response = new LoginResponse();
    //
    //     if (!_userMetaDataDbContext.UserMetaData.AsNoTracking().Any(u => u.Id == userMetaDataViewmodel.Id))
    //     {
    //         _userMetaDataDbContext.UserMetaData.Add(
    //             _mapper.Map<Postgres.Models.UserMetaData.UserMetaData>(userMetaDataViewmodel));
    //         response.Result = LoginResult.FirstLogin;
    //     }
    //
    //     response.Result = LoginResult.Succesvol;
    //     return Task.FromResult(response);
    // }
    public Task<LoginResponse> AuthenticateUser(UserMetaDataViewmodel userMetaDataViewmodel, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}