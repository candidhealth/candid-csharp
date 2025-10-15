using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[Serializable]
public record EligibilityCheck : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("batch_id")]
    public string? BatchId { get; set; }

    [JsonPropertyName("errors")]
    public IEnumerable<EligibilityCheckError>? Errors { get; set; }

    [JsonPropertyName("request")]
    public EligibilityRequest? Request { get; set; }

    [JsonPropertyName("response")]
    public required object Response { get; set; }

    [JsonPropertyName("parsed_response")]
    public ParsedResponse? ParsedResponse { get; set; }

    [JsonPropertyName("request_corrections")]
    public IEnumerable<RequestCorrection>? RequestCorrections { get; set; }

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
