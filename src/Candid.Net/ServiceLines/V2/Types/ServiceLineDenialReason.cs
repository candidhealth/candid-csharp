using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ServiceLines.V2;

/// <summary>
/// The reason a given service line was denied within a given time range.
/// A service line may be denied for different reasons over time, but only one reason at a time.
/// </summary>
[Serializable]
public record ServiceLineDenialReason : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Text of the denial reason
    /// </summary>
    [JsonPropertyName("reason")]
    public DenialReasonContent? Reason { get; set; }

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
