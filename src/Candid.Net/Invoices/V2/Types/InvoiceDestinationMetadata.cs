using System.Text.Json;
using System.Text.Json.Serialization;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.Invoices.V2;

[Serializable]
public record InvoiceDestinationMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Defines which third-party service this invoice was created in
    /// </summary>
    [JsonPropertyName("invoice_destination")]
    public required InvoiceDestination InvoiceDestination { get; set; }

    /// <summary>
    /// The id of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("source_id")]
    public required string SourceId { get; set; }

    /// <summary>
    /// The id of the customer that the invoice is attributed to in the third-party service
    /// </summary>
    [JsonPropertyName("source_customer_id")]
    public required string SourceCustomerId { get; set; }

    /// <summary>
    /// The status of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("destination_status")]
    public string? DestinationStatus { get; set; }

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
