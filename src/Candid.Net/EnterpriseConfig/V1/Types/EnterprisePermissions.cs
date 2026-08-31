using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;
using global::System.Text.Json.Serialization;

namespace Candid.Net.EnterpriseConfig.V1;

/// <summary>
/// Derived write permissions for the requesting organization, based on its enterprise configuration.
/// </summary>
[Serializable]
public record EnterprisePermissions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether the requesting organization may create, update, and archive work queues.
    /// </summary>
    [JsonPropertyName("write_queues")]
    public required bool WriteQueues { get; set; }

    /// <summary>
    /// Whether the requesting organization may create and manage rules and rule variables.
    /// </summary>
    [JsonPropertyName("write_rules")]
    public required bool WriteRules { get; set; }

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
