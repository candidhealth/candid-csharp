using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

[JsonConverter(typeof(EnumSerializer<InterventionCategory>))]
public enum InterventionCategory
{
    [EnumMember(Value = "allopathic")]
    Allopathic,

    [EnumMember(Value = "naturopathic")]
    Naturopathic,

    [EnumMember(Value = "tests")]
    Tests,

    [EnumMember(Value = "lifestyle")]
    Lifestyle,
}
