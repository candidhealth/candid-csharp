using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record ServiceLinesMustHaveAtLeastOneDiagnosisError
{
    [JsonPropertyName("diagnosis_id")]
    public required string DiagnosisId { get; set; }

    [JsonPropertyName("service_line_id")]
    public required string ServiceLineId { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
