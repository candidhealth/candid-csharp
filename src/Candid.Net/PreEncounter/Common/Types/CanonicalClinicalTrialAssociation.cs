using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter;

public record CanonicalClinicalTrialAssociation
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("clinical_trial_arm")]
    public string? ClinicalTrialArm { get; set; }

    [JsonPropertyName("period")]
    public Period? Period { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
