using System.Text.Json.Serialization;
using Candid.Net;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V1;

public record ExpectedNetworkStatusRequest
{
    [JsonPropertyName("external_patient_id")]
    public string? ExternalPatientId { get; init; }

    [JsonPropertyName("subscriber_payer_id")]
    public required string SubscriberPayerId { get; init; }

    [JsonPropertyName("subscriber_payer_name")]
    public required string SubscriberPayerName { get; init; }

    [JsonPropertyName("subscriber_insurance_type")]
    public InsuranceTypeCode? SubscriberInsuranceType { get; init; }

    /// <summary>
    /// The descriptive name of the insurance plan selected by the subscriber, often indicating coverage specifics or tier.
    /// </summary>
    [JsonPropertyName("subscriber_plan_name")]
    public string? SubscriberPlanName { get; init; }

    /// <summary>
    /// The National Provider Identifier (NPI) of the healthcare provider responsible for billing. A unique 10-digit identification number.
    /// </summary>
    [JsonPropertyName("billing_provider_npi")]
    public required string BillingProviderNpi { get; init; }

    /// <summary>
    /// Follow the 9-digit format of the Taxpayer Identification Number (TIN).
    /// </summary>
    [JsonPropertyName("billing_provider_tin")]
    public required string BillingProviderTin { get; init; }

    /// <summary>
    /// The National Provider Identifier (NPI) of the healthcare provider who delivered the services. A unique 10-digit identification number.
    /// </summary>
    [JsonPropertyName("rendering_provider_npi")]
    public required string RenderingProviderNpi { get; init; }

    /// <summary>
    /// The state in which the healthcare provider has a contractual agreement with the insurance payer.
    /// </summary>
    [JsonPropertyName("contracted_state")]
    public required State ContractedState { get; init; }

    /// <summary>
    /// Date formatted as YYYY-MM-DD; eg: 2019-08-25.
    ///
    /// </summary>
    [JsonPropertyName("date_of_service")]
    public required string DateOfService { get; init; }
}
