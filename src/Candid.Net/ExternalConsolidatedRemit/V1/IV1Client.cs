using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns metadata for every ERA payment (835 transaction set) associated with a
    /// consolidated remit, including the source ERA document for each, and indicates which ERA
    /// payment is currently elected as primary.
    /// </summary>
    WithRawResponseTask<ExternalConsolidatedRemitEraPaymentsResponse> GetEraPaymentsAsync(
        string consolidatedRemitId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Paginated, combined list of InsurancePayment and InsuranceAdjustment transactions posted
    /// from a consolidated remit's ERA payments - covering service-payment-driven and
    /// payment-bundle-driven activity of both kinds, and both the posted and voided sides of each
    /// (see is_void). Each item is discriminated by type; fields common to both transaction types
    /// are always present alongside the type-specific ones. One combined, single-cursor
    /// pagination stream rather than two separate endpoints - filter to a single type with
    /// transaction_type if you only care about one.
    /// </summary>
    WithRawResponseTask<ExternalConsolidatedRemitTransactionPage> GetTransactionsAsync(
        string consolidatedRemitId,
        GetExternalConsolidatedRemitTransactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
