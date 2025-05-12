using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.EncounterAttachments.V1;

[JsonConverter(typeof(EnumSerializer<EncounterAttachmentType>))]
public enum EncounterAttachmentType
{
    [EnumMember(Value = "DOCUMENTATION")]
    Documentation,

    [EnumMember(Value = "EOB")]
    Eob,

    [EnumMember(Value = "OTHER")]
    Other,
}
