using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record PhoneNumber
{
    [JsonPropertyName("number")]
    public required string Number { get; init; }

    [JsonPropertyName("type")]
    public required PhoneNumberType Type { get; init; }
}
