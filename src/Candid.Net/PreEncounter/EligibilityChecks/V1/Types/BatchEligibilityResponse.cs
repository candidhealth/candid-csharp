using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record BatchEligibilityResponse
{
    [JsonPropertyName("batch_id")]
    public required string BatchId { get; set; }

    [JsonPropertyName("submitted_at")]
    public required DateTime SubmittedAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
