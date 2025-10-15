using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.ClinicalTrials.V1;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayers.V1;

[Serializable]
public record NonInsurancePayer : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonPropertyName("address")]
    public StreetAddressShortZip? Address { get; set; }

    [JsonPropertyName("clinical_trials")]
    public IEnumerable<ClinicalTrial> ClinicalTrials { get; set; } = new List<ClinicalTrial>();

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
