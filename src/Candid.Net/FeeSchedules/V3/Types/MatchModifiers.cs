using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

/// <summary>
/// Match information for procedure modifiers
/// </summary>
[Serializable]
public record MatchModifiers : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("value")]
    public HashSet<ProcedureModifier> Value { get; set; } = new HashSet<ProcedureModifier>();

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
