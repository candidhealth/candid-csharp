using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

public record Address
{
    [JsonPropertyName("use")]
    public required AddressUse Use { get; init; }

    [JsonPropertyName("line")]
    public IEnumerable<string> Line { get; init; } = new List<string>();

    [JsonPropertyName("city")]
    public required string City { get; init; }

    [JsonPropertyName("state")]
    public required string State { get; init; }

    [JsonPropertyName("postal_code")]
    public required string PostalCode { get; init; }

    [JsonPropertyName("country")]
    public required string Country { get; init; }

    [JsonPropertyName("period")]
    public Period? Period { get; init; }
}
