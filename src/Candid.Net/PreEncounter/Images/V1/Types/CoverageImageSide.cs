using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Images.V1;

[JsonConverter(typeof(EnumSerializer<CoverageImageSide>))]
public enum CoverageImageSide
{
    [EnumMember(Value = "FRONT")]
    Front,

    [EnumMember(Value = "BACK")]
    Back,
}
