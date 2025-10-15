using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

[Serializable]
public record EligibilityCheckMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("check_id")]
    public required string CheckId { get; set; }

    [JsonPropertyName("service_code")]
    public required ServiceTypeCode ServiceCode { get; set; }

    [JsonPropertyName("status")]
    public required EligibilityCheckStatus Status { get; set; }

    [JsonPropertyName("initiated_by")]
    public required string InitiatedBy { get; set; }

    [JsonPropertyName("initiated_at")]
    public required DateTime InitiatedAt { get; set; }

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
