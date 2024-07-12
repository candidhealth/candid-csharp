using Candid.Net;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public record SearchImportedInvoicesRequest
{
    public string? PatientExternalId { get; init; }

    public string? EncounterExternalId { get; init; }

    /// <summary>
    /// partial match supported
    /// </summary>
    public string? Note { get; init; }

    /// <summary>
    /// all invoices whose due date is before this due date, not inclusive
    /// </summary>
    public DateOnly? DueDateBefore { get; init; }

    /// <summary>
    /// all invoices whose due date is after this due date, not inclusive
    /// </summary>
    public DateOnly? DueDateAfter { get; init; }

    /// <summary>
    /// all invoices that match any of the provided statuses
    /// </summary>
    public InvoiceStatus? Status { get; init; }

    /// <summary>
    /// Defaults to 100
    /// </summary>
    public int? Limit { get; init; }

    /// <summary>
    /// Defaults to created_at
    /// </summary>
    public InvoiceSortField? Sort { get; init; }

    /// <summary>
    /// Sort direction. Defaults to descending order
    /// </summary>
    public SortDirection? SortDirection { get; init; }

    public string? PageToken { get; init; }
}
