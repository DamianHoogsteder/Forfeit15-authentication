using System.Runtime.Serialization;

namespace Forfeit15.Auth.Core.Services.Contracts;

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