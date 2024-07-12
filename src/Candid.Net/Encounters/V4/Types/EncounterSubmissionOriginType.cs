using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Encounters.V4;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(StringEnumSerializer<EncounterSubmissionOriginType>))]
public enum EncounterSubmissionOriginType
{
    [EnumMember(Value = "CANDID")]
    Candid,

    [EnumMember(Value = "EXTERNAL")]
    External
}
