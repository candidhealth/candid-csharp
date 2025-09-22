using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

public record PhoneNumberOptional
{
    [JsonPropertyName("number")]
    public string? Number { get; set; }

    [JsonPropertyName("type")]
    public PhoneNumberType? Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
