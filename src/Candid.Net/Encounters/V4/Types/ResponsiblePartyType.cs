using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<ResponsiblePartyType>))]
public enum ResponsiblePartyType
{
    [EnumMember(Value = "INSURANCE_PAY")]
    InsurancePay,

    [EnumMember(Value = "SELF_PAY")]
    SelfPay,

    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
