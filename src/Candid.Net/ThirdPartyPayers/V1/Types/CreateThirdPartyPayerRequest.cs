using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ThirdPartyPayers.V1;

public record CreateThirdPartyPayerRequest
{
    /// <summary>
    /// Max 50 characters allowed
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Max 255 characters allowed
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// Max 255 characters allowed
    /// </summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }
}
