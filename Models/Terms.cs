﻿using System.Runtime.Serialization;
using XeroConnector.Model.Types;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class Terms : CoreData
    {
        [DataMember(EmitDefaultValue = false)]
        public int Day { get; set; }

        [DataMember(Name = "Type")]
        public PaymentTermType TermType { get; set; }
    }
}