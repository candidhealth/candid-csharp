using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

public record CanonicalNonInsurancePayerAssociation
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    /// <summary>
    /// A patient cannot be associated with a given trial more than once
    /// </summary>
    [JsonPropertyName("clinical_trial_info")]
    public IEnumerable<CanonicalClinicalTrialAssociation>? ClinicalTrialInfo { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
