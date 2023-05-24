using Forfeit15.Auth.Core.Services.Contracts;

namespace Forfeit15.Auth.Core.Services.UserMetaData;

public interface IUserMetaDataService
{
    Task<LoginResponse> AuthenticateUser(UserMetaDataViewmodel userMetaDataViewmodel,
        CancellationToken cancellationToken);
}