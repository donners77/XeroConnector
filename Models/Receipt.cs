using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using XeroConnector.Model.Status;
using XeroConnector.Model.Types;

namespace XeroConnector.Model
{
    [DataContract(Namespace = "")]
    public class Receipt : CoreData
    {
        [DataMember(Name = "ReceiptID", EmitDefaultValue = false)]
        public Guid Id { get; set; }
        
        [DataMember]
        public DateTime Date { get; set; }

        [DataMember]
        public Contact Contact { get; set; }

        [DataMember]
        public List<LineItem> LineItems { get; set; }

        [DataMember]
        public User User { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Reference { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public LineAmountType LineAmountTypes { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal SubTotal { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal TotalTax { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public decimal Total { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public ReceiptStatus Status { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string ReceiptNumber { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public bool? HasAttachments { get; set; }

        [DataMember(EmitDefaultValue = false)]
        public string Url { get; set; }        
    }
}