using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public record NonInsurancePayerUpdateRequest
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
