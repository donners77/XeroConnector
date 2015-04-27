﻿using System.Runtime.Serialization;

namespace XeroConnector.Model.Status
{
    [DataContract(Namespace = "")]
    public enum InvoiceStatus
    {
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "SUBMITTED")]
        Submitted,
        [EnumMember(Value = "DELETED")]
        Deleted,
        [EnumMember(Value = "AUTHORISED")]
        Authorised,
        [EnumMember(Value = "PAID")]
        Paid,
        [EnumMember(Value = "VOIDED")]
        Voided        
    }
}