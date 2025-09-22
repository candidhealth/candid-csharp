using System.Text.Json.Serialization;
using Candid.Net.ClinicalTrials.V1;
using Candid.Net.Commons;
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

    /// <summary>
    /// The same name cannot be used across several clinical trials
    /// </summary>
    [JsonPropertyName("clinical_trials")]
    public IEnumerable<MutableClinicalTrial>? ClinicalTrials { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
