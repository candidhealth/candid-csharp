using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

public record ExternalProvider
{
    [JsonPropertyName("name")]
    public required HumanName Name { get; set; }

    /// <summary>
    /// Defaults to ATTENDING.
    /// </summary>
    [JsonPropertyName("type")]
    public ExternalProviderType? Type { get; set; }

    [JsonPropertyName("npi")]
    public string? Npi { get; set; }

    [JsonPropertyName("telecoms")]
    public IEnumerable<ContactPoint> Telecoms { get; set; } = new List<ContactPoint>();

    [JsonPropertyName("addresses")]
    public IEnumerable<Address>? Addresses { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    [JsonPropertyName("canonical_id")]
    public string? CanonicalId { get; set; }

    [JsonPropertyName("fax")]
    public string? Fax { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
