using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net;

public record MedicareProviderIdentifier
{
    [JsonPropertyName("state")]
    public required State State { get; set; }

    [JsonPropertyName("provider_number")]
    public required string ProviderNumber { get; set; }
}
