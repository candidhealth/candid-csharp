using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public record StediPayerItem
{
    [JsonPropertyName("score")]
    public required int Score { get; set; }

    [JsonPropertyName("payer")]
    public required StediPayer Payer { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
