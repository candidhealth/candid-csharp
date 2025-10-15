using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Images.V1;

/// <summary>
/// An object representing an Image.
/// </summary>
[Serializable]
public record MutableImage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("file_name")]
    public required string FileName { get; set; }

    [JsonPropertyName("display_name")]
    public required string DisplayName { get; set; }

    [JsonPropertyName("file_type")]
    public required string FileType { get; set; }

    [JsonPropertyName("status")]
    public required ImageStatus Status { get; set; }

    [JsonPropertyName("coverage")]
    public CoverageAssociation? Coverage { get; set; }

    [JsonPropertyName("patient")]
    public PatientAssociation? Patient { get; set; }

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
