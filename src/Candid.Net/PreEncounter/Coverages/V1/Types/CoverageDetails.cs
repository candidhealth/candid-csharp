using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record CoverageDetails : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("type")]
    public required BenefitType Type { get; set; }

    [JsonPropertyName("coverageLevel")]
    public required CoverageLevel CoverageLevel { get; set; }

    [JsonPropertyName("unit")]
    public required CoverageValueUnit Unit { get; set; }

    [JsonPropertyName("value")]
    public required double Value { get; set; }

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
