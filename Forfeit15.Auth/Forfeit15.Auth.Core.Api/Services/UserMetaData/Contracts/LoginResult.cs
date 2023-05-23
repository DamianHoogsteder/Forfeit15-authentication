using System.Runtime.Serialization;

namespace Forfeit15.Auth.Core.Services.UserMetaData.Contracts
{
    [DataContract]
    public enum LoginResult
    {
        [DataMember]
        Succesvol,
        
        [DataMember]
        FirstLogin,
        
        [DataMember]
        AuthenticationFailed
    }
}