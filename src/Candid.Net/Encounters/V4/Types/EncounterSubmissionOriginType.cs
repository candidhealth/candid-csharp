using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(EnumSerializer<EncounterSubmissionOriginType>))]
public enum EncounterSubmissionOriginType
{
    [EnumMember(Value = "CANDID")]
    Candid,

    [EnumMember(Value = "EXTERNAL")]
    External,
}
