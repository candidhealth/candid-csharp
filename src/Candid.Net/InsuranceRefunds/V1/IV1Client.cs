using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.InsuranceRefunds.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns all insurance refunds satisfying the search criteria AND whose organization_id matches
    /// the current organization_id of the authenticated user.
    /// </summary>
    WithRawResponseTask<InsuranceRefundsPage> GetMultiAsync(
        GetMultiInsuranceRefundsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a previously created insurance refund by its `insurance_refund_id`.
    /// If the refund does not exist, a `403` will be thrown.
    /// </summary>
    WithRawResponseTask<InsuranceRefund> GetAsync(
        string insuranceRefundId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deprecated: insurance refunds should come from the payer's ERA, so that every insurance allocation is linked
    /// to the ERA service payment it records. This endpoint will be removed in a future release.
    ///
    /// Creates a new insurance refund record and returns the newly created `InsuranceRefund` object.
    /// The allocations can describe whether the refund is being applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    WithRawResponseTask<InsuranceRefund> CreateAsync(
        InsuranceRefundCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the patient refund record matching the provided insurance_refund_id. If updating the refund amount,
    /// then the allocations must be appropriately updated as well.
    /// </summary>
    WithRawResponseTask<InsuranceRefund> UpdateAsync(
        string insuranceRefundId,
        InsuranceRefundUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deprecated: deleting insurance refunds is not supported, and this endpoint will be removed in a future release.
    ///
    /// Deletes the insurance refund record matching the provided `insurance_refund_id`.
    /// If the matching record's organization_id does not match the authenticated user's
    /// current organization_id, then a response code of `403` will be returned.
    /// </summary>
    WithRawResponseTask DeleteAsync(
        string insuranceRefundId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
