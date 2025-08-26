using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V3;
using Candid.Net.OrganizationServiceFacilities.V2;
using Candid.Net.Payers.V3;

#nullable enable

namespace Candid.Net.Credentialing.V2;

public record FacilityCredentialingSpan
{
    [JsonPropertyName("facility_credentialing_span_id")]
    public required string FacilityCredentialingSpanId { get; set; }

    /// <summary>
    /// The service facility covered by the credentialing span.
    /// </summary>
    [JsonPropertyName("service_facility")]
    public required OrganizationServiceFacility ServiceFacility { get; set; }

    /// <summary>
    /// The practice location at which the rendering provider is covered by the credentialing span.
    /// </summary>
    [JsonPropertyName("contracting_provider")]
    public required OrganizationProviderV2 ContractingProvider { get; set; }

    /// <summary>
    /// The payer doing the credentialing.
    /// </summary>
    [JsonPropertyName("payer")]
    public required Payer Payer { get; set; }

    /// <summary>
    /// Start date of the credentialing span.
    /// </summary>
    [JsonPropertyName("start_date")]
    public DateOnly? StartDate { get; set; }

    /// <summary>
    /// End date of the credentialing span.
    /// </summary>
    [JsonPropertyName("end_date")]
    public DateOnly? EndDate { get; set; }

    /// <summary>
    /// Date that the credential paperwork was submitted.
    /// </summary>
    [JsonPropertyName("submitted_date")]
    public DateOnly? SubmittedDate { get; set; }

    /// <summary>
    /// Status of the credentialing span.
    /// </summary>
    [JsonPropertyName("credentialing_status")]
    public required CredentialingSpanStatus CredentialingStatus { get; set; }

    /// <summary>
    /// Date that the payer loaded the credentialing span into their system.
    /// </summary>
    [JsonPropertyName("payer_loaded_date")]
    public DateOnly? PayerLoadedDate { get; set; }

    /// <summary>
    /// Is the credentialing span enabled?
    /// </summary>
    [JsonPropertyName("is_enabled")]
    public required bool IsEnabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
