using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(EnumSerializer<LabCodeType>))]
public enum LabCodeType
{
    [EnumMember(Value = "quest")]
    Quest,

    [EnumMember(Value = "labcorp")]
    Labcorp,
}
