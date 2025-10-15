using System.Text.Json.Serialization;
using Candid.Net.Commons;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V1;

[Serializable]
public record ExpectedNetworkStatusRequest
{
    [JsonPropertyName("external_patient_id")]
    public string? ExternalPatientId { get; set; }

    [JsonPropertyName("subscriber_payer_id")]
    public required string SubscriberPayerId { get; set; }

    [JsonPropertyName("subscriber_payer_name")]
    public required string SubscriberPayerName { get; set; }

    [JsonPropertyName("subscriber_insurance_type")]
    public global::Candid.Net.Commons.InsuranceTypeCode? SubscriberInsuranceType { get; set; }

    /// <summary>
    /// The descriptive name of the insurance plan selected by the subscriber, often indicating coverage specifics or tier.
    /// </summary>
    [JsonPropertyName("subscriber_plan_name")]
    public string? SubscriberPlanName { get; set; }

    /// <summary>
    /// The National Provider Identifier (NPI) of the healthcare provider responsible for billing. A unique 10-digit identification number.
    /// </summary>
    [JsonPropertyName("billing_provider_npi")]
    public required string BillingProviderNpi { get; set; }

    /// <summary>
    /// Follow the 9-digit format of the Taxpayer Identification Number (TIN).
    /// </summary>
    [JsonPropertyName("billing_provider_tin")]
    public required string BillingProviderTin { get; set; }

    /// <summary>
    /// The National Provider Identifier (NPI) of the healthcare provider who delivered the services. A unique 10-digit identification number.
    /// </summary>
    [JsonPropertyName("rendering_provider_npi")]
    public required string RenderingProviderNpi { get; set; }

    /// <summary>
    /// The state in which the healthcare provider has a contractual agreement with the insurance payer.
    /// </summary>
    [JsonPropertyName("contracted_state")]
    public required State ContractedState { get; set; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public required string DateOfService { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
