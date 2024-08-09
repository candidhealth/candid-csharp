using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record PhoneNumber
{
    [JsonPropertyName("number")]
    public required string Number { get; set; }

    [JsonPropertyName("type")]
    public required PhoneNumberType Type { get; set; }
}
