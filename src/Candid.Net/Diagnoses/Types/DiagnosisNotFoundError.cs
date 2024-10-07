using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public record DiagnosisNotFoundError
{
    [JsonPropertyName("diagnosis_id")]
    public string? DiagnosisId { get; set; }

    [JsonPropertyName("message")]
    public required string Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
