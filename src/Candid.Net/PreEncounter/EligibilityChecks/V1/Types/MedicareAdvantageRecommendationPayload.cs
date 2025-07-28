using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record MedicareAdvantageRecommendationPayload
{
    [JsonPropertyName("payer_id")]
    public required string PayerId { get; set; }

    [JsonPropertyName("payer_name")]
    public required string PayerName { get; set; }

    [JsonPropertyName("member_id")]
    public string? MemberId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
