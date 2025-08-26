using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Credentialing.V2;

public record FacilityCredentialingSpanCreate
{
    /// <summary>
    /// The ID of the service facility covered by the credentialing span.
    /// </summary>
    [JsonPropertyName("service_facility_id")]
    public required string ServiceFacilityId { get; set; }

    /// <summary>
    /// The ID of the billing provider for which the service facility is covered by the credentialing span.
    /// </summary>
    [JsonPropertyName("contracting_provider_id")]
    public required string ContractingProviderId { get; set; }

    /// <summary>
    /// The ID of the payer covered by the credentialing span.
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public required string PayerUuid { get; set; }

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
    /// Date that the payer loaded the credentialing span into their system.
    /// </summary>
    [JsonPropertyName("payer_loaded_date")]
    public DateOnly? PayerLoadedDate { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
