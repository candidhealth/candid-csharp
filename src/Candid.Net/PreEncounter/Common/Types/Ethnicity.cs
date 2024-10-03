using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

[JsonConverter(typeof(StringEnumSerializer<Ethnicity>))]
public enum Ethnicity
{
    [EnumMember(Value = "HISPANIC_OR_LATINO")]
    HispanicOrLatino,

    [EnumMember(Value = "NOT_HISPANIC_OR_LATINO")]
    NotHispanicOrLatino,

    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    [EnumMember(Value = "REFUSED")]
    Refused,
}
