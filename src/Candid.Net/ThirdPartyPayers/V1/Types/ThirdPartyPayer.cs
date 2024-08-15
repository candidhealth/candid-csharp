using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ThirdPartyPayers.V1;

public record ThirdPartyPayer
{
    [JsonPropertyName("third_party_payer_id")]
    public required string ThirdPartyPayerId { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("category")]
    public string? Category { get; set; }

    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }
}
