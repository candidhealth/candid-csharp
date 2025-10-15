using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Commons;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V3;

namespace Candid.Net.Credentialing.V2;

[Serializable]
public record ProviderCredentialingSpan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider_credentialing_span_id")]
    public required string ProviderCredentialingSpanId { get; set; }

    /// <summary>
    /// The rendering provider covered by the credentialing span.
    /// </summary>
    [JsonPropertyName("rendering_provider")]
    public required OrganizationProviderV2 RenderingProvider { get; set; }

    /// <summary>
    /// The states covered by the credentialing span. A span may be national and cover all states.
    /// </summary>
    [JsonPropertyName("regions")]
    public required Regions Regions { get; set; }

    /// <summary>
    /// Provider ID for the related medallion payer enrollment.
    /// </summary>
    [JsonPropertyName("medallion_payer_enrollment_id")]
    public string? MedallionPayerEnrollmentId { get; set; }

    /// <summary>
    /// Source of the credentialing span.
    /// </summary>
    [JsonPropertyName("source")]
    public required string Source { get; set; }

    /// <summary>
    /// The practice location at which the rendering provider is covered by the credentialing span.
    /// </summary>
    [JsonPropertyName("contracting_provider")]
    public required OrganizationProviderV2 ContractingProvider { get; set; }

    /// <summary>
    /// The payer doing the credentialing.
    /// </summary>
    [JsonPropertyName("payer")]
    public required global::Candid.Net.Payers.V3.Payer Payer { get; set; }

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
