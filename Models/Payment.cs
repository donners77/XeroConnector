﻿using System;
using System.Runtime.Serialization;
using XeroConnector.Model.Status;
using XeroConnector.Model.Types;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class Payment : CoreData
    {
        [DataMember(Name = "PaymentID", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        [DataMember(Name = "PaymentType", EmitDefaultValue = false)]
        public PaymentType Type { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public PaymentStatus Status { get; set; }
        
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal CurrencyRate { get; set; }

        [DataMember]
        public decimal Amount { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Reference { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? IsReconciled { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public Invoice Invoice { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public CreditNote CreditNote { get; set; }

        [DataMember]
        public Account Account { get; set; }
    }
}
