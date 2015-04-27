﻿using System.Runtime.Serialization;

namespace XeroConnector.Model.Types
{
    [DataContract(Namespace = "")]
    public enum SystemAccountType
    {
        [EnumMember(Value = "DEBTORS")]
        Debtors,
        [EnumMember(Value = "CREDITORS")]
        Creditors,
        [EnumMember(Value = "BANKCURRENCYGAIN")]
        BankCurrencyGain,
        [EnumMember(Value = "GST")]
        Tax,
        [EnumMember(Value = "GSTONIMPORTS")]
        TaxOnImports,
        [EnumMember(Value = "HISTORICAL")]
        Historical,
        [EnumMember(Value = "REALISEDCURRENCYGAIN")]
        RealisedCurrencyGain,
        [EnumMember(Value = "RETAINEDEARNINGS")]
        RetainedEarnings,
        [EnumMember(Value = "ROUNDING")]
        Rounding,
        [EnumMember(Value = "TRACKINGTRANSFERS")]
        TrackingTransfers,
        [EnumMember(Value = "UNPAIDEXPCLM")]
        UnpaidExpenseClaim,
        [EnumMember(Value = "UNREALISEDCURRENCYGAIN")]
        UnrealisedCurrencyGain,
        [EnumMember(Value = "WAGEPAYABLES")]
        WagePayables,
    }
}
