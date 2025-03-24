using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Images.V1;

[JsonConverter(typeof(EnumSerializer<ImageStatus>))]
public enum ImageStatus
{
    [EnumMember(Value = "PENDING")]
    Pending,

    [EnumMember(Value = "UPLOADED")]
    Uploaded,

    [EnumMember(Value = "FAILED")]
    Failed,
}
