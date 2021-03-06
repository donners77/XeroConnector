﻿using System.Runtime.Serialization;
using XeroConnector.Model.Types;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class Phone : CoreData
    {
        public Phone()
        {
            PhoneType = PhoneType.Default;
        }

        [DataMember]
        public PhoneType PhoneType { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string PhoneNumber { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string PhoneAreaCode { get; set; }
        
        [DataMember(EmitDefaultValue = false)]
        public string PhoneCountryCode { get; set; }        
    }
}
