using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// Payload for MD visit copay estimation from AI analysis
/// </summary>
[Serializable]
public record CopayEstimationRecommendationPayload : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The estimated copay amount in cents
    /// </summary>
    [JsonPropertyName("structured_response")]
    public int? StructuredResponse { get; set; }

    /// <summary>
    /// The AI's explanation of the copay estimate
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
