using System.Runtime.Serialization;

namespace XeroConnector.Model.Status
{
    [DataContract(Namespace = "")]
    public enum ReceiptStatus
    {
        [EnumMember(Value = "DRAFT")]
        Draft,
        [EnumMember(Value = "SUBMITTED")]
        Submitted,
        [EnumMember(Value = "AUTHORISED")]
        Authorised,
        [EnumMember(Value = "DECLINED")]
        Declined,
        [EnumMember(Value = "DELETED")]
        Deleted
    }
}