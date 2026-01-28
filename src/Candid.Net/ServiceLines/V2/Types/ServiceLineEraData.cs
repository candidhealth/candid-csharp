using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ServiceLines.V2;

[Serializable]
public record ServiceLineEraData : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Deprecated. This field aggregates all CARCs across a service line's history
    /// without granular context
    /// (e.g., which CARCs relate to denials vs. payments vs. reversals), making it
    /// unsuitable for denial analysis or operational workflows.
    /// </summary>
    [JsonPropertyName("service_line_adjustments")]
    public IEnumerable<ServiceLineAdjustment> ServiceLineAdjustments { get; set; } =
        new List<ServiceLineAdjustment>();

    [JsonPropertyName("remittance_advice_remark_codes")]
    public IEnumerable<string> RemittanceAdviceRemarkCodes { get; set; } = new List<string>();

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
