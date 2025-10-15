using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[Serializable]
public record Medication : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("rx_cui")]
    public string? RxCui { get; set; }

    [JsonPropertyName("dosage")]
    public string? Dosage { get; set; }

    [JsonPropertyName("dosage_form")]
    public string? DosageForm { get; set; }

    [JsonPropertyName("frequency")]
    public string? Frequency { get; set; }

    [JsonPropertyName("as_needed")]
    public bool? AsNeeded { get; set; }

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
