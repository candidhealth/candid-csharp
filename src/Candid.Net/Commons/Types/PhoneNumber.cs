using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Commons;

public record PhoneNumber
{
    [JsonPropertyName("number")]
    public required string Number { get; set; }

    [JsonPropertyName("type")]
    public required PhoneNumberType Type { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
