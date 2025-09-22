using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record EpsdtReferral
{
    [JsonPropertyName("condition_indicator1")]
    public required EpsdtReferralConditionIndicatorCode ConditionIndicator1 { get; set; }

    [JsonPropertyName("condition_indicator2")]
    public EpsdtReferralConditionIndicatorCode? ConditionIndicator2 { get; set; }

    [JsonPropertyName("condition_indicator3")]
    public EpsdtReferralConditionIndicatorCode? ConditionIndicator3 { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
