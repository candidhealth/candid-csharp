using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record PlanCoverageDetails : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("deductible")]
    public CoverageValue? Deductible { get; set; }

    [JsonPropertyName("deductible_contract")]
    public CoverageValue? DeductibleContract { get; set; }

    [JsonPropertyName("deductible_remaining")]
    public CoverageValue? DeductibleRemaining { get; set; }

    [JsonPropertyName("deductible_year_to_date")]
    public CoverageValue? DeductibleYearToDate { get; set; }

    [JsonPropertyName("oop_max")]
    public CoverageValue? OopMax { get; set; }

    [JsonPropertyName("oop_max_contract")]
    public CoverageValue? OopMaxContract { get; set; }

    [JsonPropertyName("oop_max_remaining")]
    public CoverageValue? OopMaxRemaining { get; set; }

    [JsonPropertyName("oop_max_year_to_date")]
    public CoverageValue? OopMaxYearToDate { get; set; }

    [JsonPropertyName("additional_notes")]
    public string? AdditionalNotes { get; set; }

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
