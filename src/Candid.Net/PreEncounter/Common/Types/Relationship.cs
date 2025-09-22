using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Common;

[JsonConverter(typeof(EnumSerializer<Relationship>))]
public enum Relationship
{
    [EnumMember(Value = "SELF")]
    Self,

    [EnumMember(Value = "SPOUSE")]
    Spouse,

    [EnumMember(Value = "CHILD")]
    Child,

    [EnumMember(Value = "COMMON_LAW_SPOUSE")]
    CommonLawSpouse,

    [EnumMember(Value = "OTHER")]
    Other,
}
