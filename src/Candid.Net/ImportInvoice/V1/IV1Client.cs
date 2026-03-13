using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ImportInvoice.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Import an existing invoice from a third party service to reflect state in Candid.
    /// </summary>
    WithRawResponseTask<ImportInvoice> ImportInvoiceAsync(
        CreateImportInvoiceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Returns all Invoices for the authenticated user's organziation with all filters applied.
    /// </summary>
    WithRawResponseTask<ImportInvoicesPage> GetMultiAsync(
        SearchImportedInvoicesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve and view an import invoice
    /// </summary>
    WithRawResponseTask<ImportInvoice> GetAsync(
        string invoiceId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update the information on the imported invoice
    /// </summary>
    WithRawResponseTask<ImportInvoice> UpdateAsync(
        string invoiceId,
        ImportInvoiceUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
