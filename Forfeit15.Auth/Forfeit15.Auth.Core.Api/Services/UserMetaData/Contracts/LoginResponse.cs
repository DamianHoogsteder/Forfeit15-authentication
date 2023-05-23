using System.Runtime.Serialization;
using Forfeit15.Auth.Core.Services.UserMetaData.Contracts;

namespace Forfeit15.Auth.Core.Api.Services.UserMetaData.Contracts
{
    [DataContract]
    public class LoginResponse
    {
        [DataMember]
        public UserMetaDataViewmodel UserMetaDataViewmodel { get; set; }
        
        [DataMember] 
        public LoginResult Result { get; set; }
    }
}