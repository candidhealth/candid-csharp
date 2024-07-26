using System.Text.Json.Serialization;
using Candid.Net.ExpectedNetworkStatus.V2;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public record ExpectedNetworkStatusSubscriberInformation
{
    /// <summary>
    /// The UUID that corresponds with the payer on the patient’s insurance card
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; init; }

    /// <summary>
    /// The member_id on the patient’s insurance card
    /// </summary>
    [JsonPropertyName("member_id")]
    public required string MemberId { get; init; }

    /// <summary>
    /// The insurance information on the patient's insurance card
    /// </summary>
    [JsonPropertyName("insurance_type")]
    public required InsuranceType InsuranceType { get; init; }
}
