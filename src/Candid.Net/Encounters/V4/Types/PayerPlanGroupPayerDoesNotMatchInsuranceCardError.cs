using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Encounters.V4;

public record PayerPlanGroupPayerDoesNotMatchInsuranceCardError
{
    [JsonPropertyName("payer_plan_group_payer_uuid")]
    public required string PayerPlanGroupPayerUuid { get; set; }

    [JsonPropertyName("insurance_card_payer_uuid")]
    public string? InsuranceCardPayerUuid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
