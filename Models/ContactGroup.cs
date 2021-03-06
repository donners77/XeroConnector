﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class ContactGroup : CoreData
    {
        [DataMember(Name = "ContactGroupID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Name { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public List<Contact> Contacts { get; set; }        
    }
}