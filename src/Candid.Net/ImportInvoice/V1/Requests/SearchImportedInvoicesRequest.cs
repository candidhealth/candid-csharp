using System.Text.Json.Serialization;
using Candid.Net.Core;
using Candid.Net.Invoices.V2;

namespace Candid.Net.ImportInvoice.V1;

[Serializable]
public record SearchImportedInvoicesRequest
{
    [JsonIgnore]
    public string? PatientExternalId { get; set; }

    [JsonIgnore]
    public string? EncounterExternalId { get; set; }

    /// <summary>
    /// partial match supported
    /// </summary>
    [JsonIgnore]
    public string? Note { get; set; }

    /// <summary>
    /// all invoices whose due date is before this due date, not inclusive
    /// </summary>
    [JsonIgnore]
    public DateOnly? DueDateBefore { get; set; }

    /// <summary>
    /// all invoices whose due date is after this due date, not inclusive
    /// </summary>
    [JsonIgnore]
    public DateOnly? DueDateAfter { get; set; }

    /// <summary>
    /// all invoices that match any of the provided statuses
    /// </summary>
    [JsonIgnore]
    public IEnumerable<global::Candid.Net.Invoices.V2.InvoiceStatus> Status { get; set; } =
        new List<global::Candid.Net.Invoices.V2.InvoiceStatus>();

    /// <summary>
    /// Defaults to 100
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// Defaults to created_at
    /// </summary>
    [JsonIgnore]
    public InvoiceSortField? Sort { get; set; }

    /// <summary>
    /// Sort direction. Defaults to descending order
    /// </summary>
    [JsonIgnore]
    public global::Candid.Net.Commons.SortDirection? SortDirection { get; set; }

    [JsonIgnore]
    public string? PageToken { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
