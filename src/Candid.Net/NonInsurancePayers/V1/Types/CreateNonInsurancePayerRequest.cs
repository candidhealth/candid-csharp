using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public record CreateNonInsurancePayerRequest
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

    [JsonPropertyName("address")]
    public StreetAddressShortZip? Address { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
