using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Individual result from a single user-configured prompt execution
/// </summary>
[Serializable]
public record UserConfiguredPromptsResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Reference to the user prompt in eligibility config
    /// </summary>
    [JsonPropertyName("user_prompt_id")]
    public required string UserPromptId { get; set; }

    /// <summary>
    /// User-defined name for the prompt
    /// </summary>
    [JsonPropertyName("prompt_name")]
    public required string PromptName { get; set; }

    /// <summary>
    /// The AI's structured answer (boolean, number, or string)
    /// </summary>
    [JsonPropertyName("structured_response")]
    public required object StructuredResponse { get; set; }

    /// <summary>
    /// The AI's explanation of the answer
    /// </summary>
    [JsonPropertyName("exposition")]
    public required string Exposition { get; set; }

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
