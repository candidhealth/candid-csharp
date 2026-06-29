using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.FeeSchedules.V3;

[Serializable]
public record RateUploadWithPossibleErrors : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("rate_upload")]
    public required RateUpload RateUpload { get; set; }

    [JsonPropertyName("existing_rate")]
    public Rate? ExistingRate { get; set; }

    [JsonPropertyName("possible_errors")]
    public IEnumerable<ValidationError> PossibleErrors { get; set; } = new List<ValidationError>();

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
