using System.Text.Json.Serialization;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Credentialing.V2;

public record ProviderCredentialingSpanUpdate
{
    /// <summary>
    /// The ID of the practice location at which the rendering provider is covered by the credentialing span.
    /// </summary>
    [JsonPropertyName("contracting_provider_id")]
    public string? ContractingProviderId { get; set; }

    /// <summary>
    /// The ID of the payer doing the credentialing.
    /// </summary>
    [JsonPropertyName("payer_uuid")]
    public string? PayerUuid { get; set; }

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
    /// The states covered by the credentialing span. A span may be national and cover all states.
    /// </summary>
    [JsonPropertyName("regions")]
    public object? Regions { get; set; }

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
