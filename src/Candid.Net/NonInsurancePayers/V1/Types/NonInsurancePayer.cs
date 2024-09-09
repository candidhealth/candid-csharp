using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public record NonInsurancePayer
{
    [JsonPropertyName("non_insurance_payer_id")]
    public required string NonInsurancePayerId { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}
