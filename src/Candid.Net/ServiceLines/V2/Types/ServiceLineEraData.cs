using System.Text.Json.Serialization;
using Candid.Net.ServiceLines.V2;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLineEraData
{
    [JsonPropertyName("service_line_adjustments")]
    public IEnumerable<ServiceLineAdjustment> ServiceLineAdjustments { get; init; } =
        new List<ServiceLineAdjustment>();

    [JsonPropertyName("remittance_advice_remark_codes")]
    public IEnumerable<string> RemittanceAdviceRemarkCodes { get; init; } = new List<string>();
}
