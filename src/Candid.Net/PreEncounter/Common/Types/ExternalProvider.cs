using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.PreEncounter;

public record ExternalProvider
{
    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    [JsonPropertyName("type")]
    public ExternalProviderType? Type { get; set; }

    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    [JsonPropertyName("telecoms")]
    public IEnumerable<ContactPoint> Telecoms { get; set; } = new List<ContactPoint>();

    [JsonPropertyName("addresses")]
    public IEnumerable<Address> Addresses { get; set; } = new List<Address>();

    [JsonPropertyName("period")]
    public Period? Period { get; set; }
}