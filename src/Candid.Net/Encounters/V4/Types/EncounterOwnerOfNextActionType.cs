using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<EncounterOwnerOfNextActionType>))]
public enum EncounterOwnerOfNextActionType
{
    [EnumMember(Value = "CANDID")]
    Candid,

    [EnumMember(Value = "CUSTOMER")]
    Customer,

    [EnumMember(Value = "CODER")]
    Coder,

    [EnumMember(Value = "NONE")]
    None
}
