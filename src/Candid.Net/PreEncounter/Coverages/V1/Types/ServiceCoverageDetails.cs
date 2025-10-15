using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record ServiceCoverageDetails : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("copay")]
    public CoverageValue? Copay { get; set; }

    [JsonPropertyName("coinsurance")]
    public CoverageValue? Coinsurance { get; set; }

    [JsonPropertyName("visits")]
    public CoverageValue? Visits { get; set; }

    [JsonPropertyName("visits_remaining")]
    public CoverageValue? VisitsRemaining { get; set; }

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
