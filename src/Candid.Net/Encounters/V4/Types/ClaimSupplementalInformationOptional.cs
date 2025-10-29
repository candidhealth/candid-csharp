using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

[Serializable]
public record ClaimSupplementalInformationOptional : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("attachment_report_type_code")]
    public ReportTypeCode? AttachmentReportTypeCode { get; set; }

    [JsonPropertyName("attachment_transmission_code")]
    public ReportTransmissionCode? AttachmentTransmissionCode { get; set; }

    [JsonPropertyName("attachment_control_number")]
    public string? AttachmentControlNumber { get; set; }

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
