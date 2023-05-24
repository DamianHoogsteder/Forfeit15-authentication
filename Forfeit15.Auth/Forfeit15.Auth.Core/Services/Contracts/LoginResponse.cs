using System.Runtime.Serialization;
using Forfeit15.Auth.Core.Services.UserMetaData;

namespace Forfeit15.Auth.Core.Services.Contracts;

[DataContract]
public class LoginResponse
{
    [DataMember]
    public UserMetaDataViewmodel UserMetaDataViewmodel { get; set; }
        
    [DataMember] 
    public LoginResult Result { get; set; }
}