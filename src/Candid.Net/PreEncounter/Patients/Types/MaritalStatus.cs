using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<MaritalStatus>))]
public enum MaritalStatus
{
    [EnumMember(Value = "ANNULLED")]
    Annulled,

    [EnumMember(Value = "DIVORCED")]
    Divorced,

    [EnumMember(Value = "INTERLOCUTORY")]
    Interlocutory,

    [EnumMember(Value = "SEPARATED")]
    Separated,

    [EnumMember(Value = "MARRIED")]
    Married,

    [EnumMember(Value = "COMMON_LAW")]
    CommonLaw,

    [EnumMember(Value = "POLYGAMOUS")]
    Polygamous,

    [EnumMember(Value = "DOMESTIC_PARTNER")]
    DomesticPartner,

    [EnumMember(Value = "UNMARRIED")]
    Unmarried,

    [EnumMember(Value = "NEVER_MARRIED")]
    NeverMarried,

    [EnumMember(Value = "WIDOWED")]
    Widowed,

    [EnumMember(Value = "UNKNOWN")]
    Unknown
}
