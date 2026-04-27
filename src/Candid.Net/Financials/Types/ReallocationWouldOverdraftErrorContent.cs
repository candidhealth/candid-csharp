using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Financials;

/// <summary>
/// Error content when a reallocation would cause an account to be overdrafted.
/// Contains both legacy string messages and new structured allocation details.
/// </summary>
[Serializable]
public record ReallocationWouldOverdraftErrorContent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Legacy field containing error messages as strings.
    /// Deprecated - use allocation_details for structured data.
    /// Will be removed in a future version after frontend migration.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<string> Messages { get; set; } = new List<string>();

    /// <summary>
    /// Structured details about which allocations would be overdrafted.
    /// Each detail includes entity type, ID, and error message for table display.
    /// </summary>
    [JsonPropertyName("allocation_details")]
    public IEnumerable<AllocationOverdraftDetail>? AllocationDetails { get; set; }

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
