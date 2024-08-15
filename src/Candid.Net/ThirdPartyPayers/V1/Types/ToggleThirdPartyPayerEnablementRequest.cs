using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ThirdPartyPayers.V1;

public record ToggleThirdPartyPayerEnablementRequest
{
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}
