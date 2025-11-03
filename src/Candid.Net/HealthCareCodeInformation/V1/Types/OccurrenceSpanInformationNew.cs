using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

/// <summary>
/// This corresponds to the BI code qualifier value.
/// </summary>
[Serializable]
public record OccurrenceSpanInformationNew : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("occurrence_span_code_qualifier")]
    public required OccurrenceSpanCodeQualifier OccurrenceSpanCodeQualifier { get; set; }

    [JsonPropertyName("occurrence_span_code")]
    public required OccurrenceSpanCode OccurrenceSpanCode { get; set; }

    [JsonPropertyName("occurrence_span_date")]
    public required Rd8Date OccurrenceSpanDate { get; set; }

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
