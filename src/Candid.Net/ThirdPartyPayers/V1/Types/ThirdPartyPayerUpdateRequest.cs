using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.ThirdPartyPayers.V1;

public record ThirdPartyPayerUpdateRequest
{
    /// <summary>
    /// Max 50 characters allowed
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("description")]
    public object? Description { get; set; }

    [JsonPropertyName("category")]
    public object? Category { get; set; }
}
