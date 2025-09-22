using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

[JsonConverter(typeof(EnumSerializer<Clearinghouse>))]
public enum Clearinghouse
{
    [EnumMember(Value = "CHANGE_HEALTHCARE")]
    ChangeHealthcare,

    [EnumMember(Value = "OLIVE")]
    Olive,

    [EnumMember(Value = "UCSF_CIRIUS")]
    UcsfCirius,

    [EnumMember(Value = "AVAILITY")]
    Availity,

    [EnumMember(Value = "PAYER_PORTAL")]
    PayerPortal,

    [EnumMember(Value = "STEDI")]
    Stedi,

    [EnumMember(Value = "WAYSTAR")]
    Waystar,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,
}
