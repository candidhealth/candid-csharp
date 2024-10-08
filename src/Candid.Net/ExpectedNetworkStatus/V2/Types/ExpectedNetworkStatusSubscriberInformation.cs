using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record ExpectedNetworkStatusSubscriberInformation
{
    /// <summary>
    /// The UUID that corresponds with the payer on the patient’s insurance card
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

    /// <summary>
    /// The member_id on the patient’s insurance card
    /// </summary>
    [JsonPropertyName("member_id")]
    public required string MemberId { get; set; }

    /// <summary>
    /// The insurance information on the patient's insurance card
    /// </summary>
    [JsonPropertyName("insurance_type")]
    public required InsuranceType InsuranceType { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
