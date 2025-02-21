using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record RequestCorrection
{
    [JsonPropertyName("property")]
    public required string Property { get; set; }

    [JsonPropertyName("request_value")]
    public required string RequestValue { get; set; }

    [JsonPropertyName("corrected_value")]
    public required string CorrectedValue { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
