using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public record ToggleNonInsurancePayerEnablementRequest
{
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}
