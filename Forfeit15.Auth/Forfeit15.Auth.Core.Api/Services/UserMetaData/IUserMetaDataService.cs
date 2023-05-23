using Forfeit15.Auth.Core.Api.Services.UserMetaData.Contracts;
using Forfeit15.Auth.Core.Services.UserMetaData.Contracts;

namespace Forfeit15.Auth.Core.Api.Services.UserMetaData
{
    public interface IUserMetaDataService
    {
        Task<LoginResponse> AuthenticateUser(UserMetaDataViewmodel userMetaDataViewmodel,
            CancellationToken cancellationToken);
    }
}