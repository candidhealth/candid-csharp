using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Payload for user-configured prompt recommendations from AI analysis
/// </summary>
[Serializable]
public record UserConfiguredPromptsRecommendationPayload : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Array of results from all enabled user-configured prompts
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<UserConfiguredPromptsResult> Results { get; set; } =
        new List<UserConfiguredPromptsResult>();

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
