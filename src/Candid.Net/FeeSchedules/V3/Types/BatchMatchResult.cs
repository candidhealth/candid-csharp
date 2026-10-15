using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.FeeSchedules.V3;

[Serializable]
public record BatchMatchResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The point from the request.
    /// </summary>
    [JsonPropertyName("point")]
    public required BatchMatchPoint Point { get; set; }

    /// <summary>
    /// The matched rate. Null means no rate matches the point.
    /// </summary>
    [JsonPropertyName("match")]
    public MatchedRate? Match { get; set; }

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
