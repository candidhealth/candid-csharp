using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.EligibilityChecks.V1;

namespace Candid.Net.PreEncounter.Coverages.V1;

/// <summary>
/// A type to represent the latest eligibility check status of a coverage.
/// </summary>
[Serializable]
public record LatestEligibilityCheck : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("check_id")]
    public required string CheckId { get; set; }

    [JsonPropertyName("status")]
    public required EligibilityStatus Status { get; set; }

    [JsonPropertyName("initiated_at")]
    public required DateTime InitiatedAt { get; set; }

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
