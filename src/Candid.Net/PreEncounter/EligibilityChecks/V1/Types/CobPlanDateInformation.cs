using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Dates associated with the patient's health plan coverage.
/// </summary>
[Serializable]
public record CobPlanDateInformation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// When the patient's health plan coverage begins.
    /// </summary>
    [JsonPropertyName("plan_begin")]
    public string? PlanBegin { get; set; }

    /// <summary>
    /// When the patient's health plan coverage ends.
    /// </summary>
    [JsonPropertyName("plan_end")]
    public string? PlanEnd { get; set; }

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
