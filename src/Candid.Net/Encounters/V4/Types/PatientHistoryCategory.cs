using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[Serializable]
public record PatientHistoryCategory : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("category")]
    public required PatientHistoryCategoryEnum Category { get; set; }

    /// <summary>
    /// Must contain at least one item.
    /// </summary>
    [JsonPropertyName("questions")]
    public IEnumerable<IntakeQuestion> Questions { get; set; } = new List<IntakeQuestion>();

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
