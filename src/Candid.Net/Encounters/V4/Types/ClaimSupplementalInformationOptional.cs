using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record ClaimSupplementalInformationOptional
{
    [JsonPropertyName("attachment_report_type_code")]
    public ReportTypeCode? AttachmentReportTypeCode { get; set; }

    [JsonPropertyName("attachment_transmission_code")]
    public ReportTransmissionCode? AttachmentTransmissionCode { get; set; }

    [JsonPropertyName("attachment_control_number")]
    public string? AttachmentControlNumber { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
