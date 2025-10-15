using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[Serializable]
public record ParsedResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("eligibility_status")]
    public required EligibilityStatus EligibilityStatus { get; set; }

    [JsonPropertyName("plan_metadata")]
    public PlanMetadata? PlanMetadata { get; set; }

    [JsonPropertyName("benefits")]
    public CoverageBenefits? Benefits { get; set; }

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
