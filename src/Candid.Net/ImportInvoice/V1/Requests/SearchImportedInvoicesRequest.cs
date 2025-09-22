using Candid.Net.Core;
using Candid.Net.Invoices.V2;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public record SearchImportedInvoicesRequest
{
    public string? PatientExternalId { get; set; }

    public string? EncounterExternalId { get; set; }

    /// <summary>
    /// partial match supported
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// all invoices whose due date is before this due date, not inclusive
    /// </summary>
    public DateOnly? DueDateBefore { get; set; }

    /// <summary>
    /// all invoices whose due date is after this due date, not inclusive
    /// </summary>
    public DateOnly? DueDateAfter { get; set; }

    /// <summary>
    /// all invoices that match any of the provided statuses
    /// </summary>
    public IEnumerable<Invoices.V2.InvoiceStatus> Status { get; set; } =
        new List<Invoices.V2.InvoiceStatus>();

    /// <summary>
    /// Defaults to 100
    /// </summary>
    public int? Limit { get; set; }

    /// <summary>
    /// Defaults to created_at
    /// </summary>
    public InvoiceSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order
    /// </summary>
    public Commons.SortDirection? SortDirection { get; set; }

    public string? PageToken { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
