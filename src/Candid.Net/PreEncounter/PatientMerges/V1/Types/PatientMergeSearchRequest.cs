using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.PatientMerges.V1;

/// <summary>
/// The search criteria for fetching patient merge records.
/// </summary>
[Serializable]
public record PatientMergeSearchRequest : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The patient MRNs to fetch merges for.
    /// </summary>
    [JsonPropertyName("mrns")]
    public IEnumerable<string> Mrns { get; set; } = new List<string>();

    /// <summary>
    /// The max number of records to return. Defaults to 100, capped at 1000.
    /// </summary>
    [JsonPropertyName("limit")]
    public int? Limit { get; set; }

    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

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
