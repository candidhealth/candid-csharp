using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Retrieve a list of inventory records based on the provided filters. Each inventory record provides the latest invoiceable status of the associated claim.
    /// The response is paginated, and the `page_token` can be used to retrieve subsequent pages. Initial requests should not include `page_token`.
    /// </summary>
    WithRawResponseTask<ListInventoryPagedResponse> ListInventoryAsync(
        GetInventoryRecordsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Provides detailed itemization of invoice data for a specific claim.
    /// </summary>
    WithRawResponseTask<InvoiceItemizationResponse> ItemizeAsync(
        string claimId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
