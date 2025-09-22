using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Identifiers;

public record MedicaidProviderIdentifier
{
    [JsonPropertyName("state")]
    public required State State { get; set; }

    [JsonPropertyName("provider_number")]
    public required string ProviderNumber { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
