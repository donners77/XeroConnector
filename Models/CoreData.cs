﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using XeroConnector.Model.Status;




namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public abstract class CoreData 
    {
        [DataMember(EmitDefaultValue = false, Name = "ValidationErrors")]
        public List<ValidationError> Errors { get; set; }

        [DataMember(EmitDefaultValue = false, Name = "Warnings")]
        public List<Warning> Warnings { get; set; }

        // It is called StatusAttributeString in JSON but is an XML attribute in XML
        [DataMember(EmitDefaultValue = false, Name = "StatusAttributeString")]
        public ValidationStatus ValidationStatus { get; set; }
    }
}
