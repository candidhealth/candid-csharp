using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.Dashboarding.V1;

/// <summary>
/// Result for a single metric query.
/// </summary>
[Serializable]
public record MetricResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("metric")]
    public required MetricName Metric { get; set; }

    /// <summary>
    /// The metric value. Null alongside a null `error` when the metric resolved but has nothing
    /// to report, which is distinct from a zero. Counts and amounts report `0` when the
    /// underlying set is empty; ages and rates report null, because there is no claim to age and
    /// no volume to take a rate over.
    /// </summary>
    [JsonPropertyName("value")]
    public double? Value { get; set; }

    /// <summary>
    /// The `snapshot` value sent on the request.
    /// </summary>
    [JsonPropertyName("snapshot")]
    public MetricSnapshot? Snapshot { get; set; }

    /// <summary>
    /// Why this metric could not be computed, absent on success.
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

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
