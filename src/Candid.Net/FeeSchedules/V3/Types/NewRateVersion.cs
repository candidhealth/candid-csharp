using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

[Serializable]
public record NewRateVersion : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rate_id")]
    public required string RateId { get; set; }

    /// <summary>
    /// New versions of rates must indicate the exact version they modify. When the system attempts to save this new version, if the latest version in the system does not equal this previos_version, the request will be rejected with a EntityConflictError.
    /// </summary>
    [JsonPropertyName("previous_version")]
    public required int PreviousVersion { get; set; }

    [JsonPropertyName("entries")]
    public IEnumerable<RateEntry> Entries { get; set; } = new List<RateEntry>();

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
