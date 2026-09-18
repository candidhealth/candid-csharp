using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.PreEncounter.Patients.V1;

[Serializable]
public record AuditCoverageUpdated : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("edits")]
    public IEnumerable<Dictionary<string, object?>> Edits { get; set; } =
        new List<Dictionary<string, object?>>();

    [JsonPropertyName("source")]
    public required CoverageUpdateSource Source { get; set; }

    [JsonPropertyName("check_id")]
    public string? CheckId { get; set; }

    [JsonPropertyName("initiator_user_id")]
    public string? InitiatorUserId { get; set; }

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
