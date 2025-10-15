using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Common;

[Serializable]
public record CanonicalNonInsurancePayerAssociation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
