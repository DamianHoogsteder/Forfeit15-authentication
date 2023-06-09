﻿using System.Runtime.Serialization;

namespace Forfeit15.Auth.Core.Services.UserMetaData;

[DataContract]
public class UserMetaDataViewmodel
{
    [DataMember] 
    public Guid Id { get; set; }
        
    [DataMember] 
        public string Name { get; set; }
            
        [DataMember(Name = "family_name")] 
        public string FamilyName { get; set; }
            
        [DataMember(Name = "given_name")] 
        public string GivenName { get; set; }
            
        [DataMember] 
        public string NickName { get; set; }
            
        [DataMember] 
        public string Email { get; set; }
            
        [DataMember] 
        public string Locale { get; set; }
            
        [DataMember] 
        public long Picture { get; set; }
            
        [DataMember] 
        public string Sub { get; set; }
            
        [DataMember(Name = "updated_at")] 
        public string UpdatedAt { get; set; }
}