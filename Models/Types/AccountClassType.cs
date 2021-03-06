﻿using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum AccountClassType
    {
        [EnumMember(Value = "ASSET")]
        Asset,
        [EnumMember(Value = "EQUITY")]
        Equity,
        [EnumMember(Value = "EXPENSE")]
        Expense,
        [EnumMember(Value = "LIABILITY")]
        Liability,
        [EnumMember(Value = "REVENUE")]
        Revenue,
    }
}
