using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

/// <summary>
/// This object is our fern representation of Stedi's EligbilityCheckError object from their API.
/// </summary>
[Serializable]
public record EligibilityCheckErrorDetails : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("field?")]
    public string? Field { get; set; }

    [JsonPropertyName("description?")]
    public string? Description { get; set; }

    [JsonPropertyName("location?")]
    public string? Location { get; set; }

    [JsonPropertyName("possibleResolutions?")]
    public string? PossibleResolutions { get; set; }

    [JsonPropertyName("code?")]
    public string? Code { get; set; }

    [JsonPropertyName("followupAction?")]
    public string? FollowupAction { get; set; }

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
