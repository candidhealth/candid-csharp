using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Coverages.V1;

[Serializable]
public record CoverageBenefits : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("plan_coverage")]
    public PlanCoverage? PlanCoverage { get; set; }

    [JsonPropertyName("service_specific_coverage")]
    public IEnumerable<ServiceCoverage>? ServiceSpecificCoverage { get; set; }

    [JsonPropertyName("benefits_related_entities")]
    public IEnumerable<BenefitsRelatedEntity>? BenefitsRelatedEntities { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("autoUpdatedEligibilityCheckId")]
    public string? AutoUpdatedEligibilityCheckId { get; set; }

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
