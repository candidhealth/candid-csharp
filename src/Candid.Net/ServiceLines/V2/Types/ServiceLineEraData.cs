using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ServiceLines.V2;

public record ServiceLineEraData
{
    [JsonPropertyName("service_line_adjustments")]
    public IEnumerable<ServiceLineAdjustment> ServiceLineAdjustments { get; set; } =
        new List<ServiceLineAdjustment>();

    [JsonPropertyName("remittance_advice_remark_codes")]
    public IEnumerable<string> RemittanceAdviceRemarkCodes { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
