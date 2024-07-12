using System.Text.Json.Serialization;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.Invoices.V2;

public record InvoiceDestinationMetadata
{
    /// <summary>
    /// Defines which third-party service this invoice was created in
    /// </summary>
    [JsonPropertyName("invoice_destination")]
    public required InvoiceDestination InvoiceDestination { get; init; }

    /// <summary>
    /// The id of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("source_id")]
    public required string SourceId { get; init; }

    /// <summary>
    /// The id of the customer that the invoice is attributed to in the third-party service
    /// </summary>
    [JsonPropertyName("source_customer_id")]
    public required string SourceCustomerId { get; init; }

    /// <summary>
    /// The status of the invoice in the third-party service
    /// </summary>
    [JsonPropertyName("destination_status")]
    public string? DestinationStatus { get; init; }
}
