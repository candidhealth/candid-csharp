using System.Text.Json.Serialization;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

public record ExternalProvider
{
    [JsonPropertyName("name")]
    public required HumanName Name { get; init; }

    [JsonPropertyName("telecoms")]
    public IEnumerable<ContactPoint> Telecoms { get; init; } = new List<ContactPoint>();

    [JsonPropertyName("addresses")]
    public IEnumerable<Address> Addresses { get; init; } = new List<Address>();

    [JsonPropertyName("period")]
    public Period? Period { get; init; }
}
