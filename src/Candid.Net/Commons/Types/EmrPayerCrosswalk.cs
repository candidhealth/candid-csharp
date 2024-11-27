using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

[JsonConverter(typeof(EnumSerializer<EmrPayerCrosswalk>))]
public enum EmrPayerCrosswalk
{
    [EnumMember(Value = "HEALTHIE")]
    Healthie,

    [EnumMember(Value = "CANVAS")]
    Canvas,
}
