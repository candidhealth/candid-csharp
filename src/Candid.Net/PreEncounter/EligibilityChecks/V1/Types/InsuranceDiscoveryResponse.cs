using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// An object representing the data for an insurance discovery response.
/// </summary>
[Serializable]
public record InsuranceDiscoveryResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A unique ID for this insurance discovery check.
    /// </summary>
    [JsonPropertyName("discovery_id")]
    public string? DiscoveryId { get; set; }

    /// <summary>
    /// The status of the discovery check. COMPLETE means items are populated. PENDING means the check is still in progress.
    /// </summary>
    [JsonPropertyName("status")]
    public InsuranceDiscoveryStatus? Status { get; set; }

    /// <summary>
    /// An array of potential coverage matches for the patient. Only populated when status is COMPLETE.
    /// Each item is a raw passthrough of Stedi's deeply nested coverage-match object (provider, subscriber,
    /// payer, plan, and benefits details).
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<object>? Items { get; set; }

    /// <summary>
    /// The number of potential coverage matches found. 0 if no matching coverage was found.
    /// </summary>
    [JsonPropertyName("coverages_found")]
    public int? CoveragesFound { get; set; }

    [JsonPropertyName("errors")]
    public IEnumerable<EligibilityCheckErrorDetails>? Errors { get; set; }

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
