using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net;

public record MedicaidProviderIdentifier
{
    [JsonPropertyName("state")]
    public required State State { get; init; }

    [JsonPropertyName("provider_number")]
    public required string ProviderNumber { get; init; }
}
