﻿using System.Runtime.Serialization;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class TaxComponent : CoreData
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public decimal Rate { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? IsCompound { get; set; }
    }
}
