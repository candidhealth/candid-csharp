using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// Match information for network types
/// </summary>
[Serializable]
public record MatchNetworkTypes : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("value")]
    public HashSet<Candid.Net.Commons.NetworkType> Value { get; set; } =
        new HashSet<Candid.Net.Commons.NetworkType>();

    [JsonPropertyName("match")]
    public required bool Match { get; set; }

    [JsonPropertyName("explanation")]
    public required string Explanation { get; set; }

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
