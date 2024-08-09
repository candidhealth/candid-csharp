using System.Text.Json.Serialization;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record InvoiceDestinationMetadata
{
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
}
