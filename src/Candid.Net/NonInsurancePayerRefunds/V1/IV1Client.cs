using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayerRefunds.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns all non-insurance payer refunds satisfying the search criteria
    /// </summary>
    WithRawResponseTask<NonInsurancePayerRefundsPage> GetMultiAsync(
        GetMultiNonInsurancePayerRefundsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a previously created non-insurance payer refund by its `non_insurance_payer_refund_id`.
    /// </summary>
    WithRawResponseTask<NonInsurancePayerRefund> GetAsync(
        string nonInsurancePayerRefundId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates a new non-insurance payer refund record and returns the newly created `NonInsurancePayerRefund` object.
    /// The allocations can describe whether the refund is being applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    WithRawResponseTask<NonInsurancePayerRefund> CreateAsync(
        NonInsurancePayerRefundCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Updates the non-insurance payer refund record matching the provided non_insurance_payer_refund_id. If updating the refund amount,
    /// then the allocations must be appropriately updated as well.
    /// </summary>
    WithRawResponseTask<NonInsurancePayerRefund> UpdateAsync(
        string nonInsurancePayerRefundId,
        NonInsurancePayerRefundUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Deletes the non-insurance payer refund record matching the provided `non_insurance_payer_refund_id`.
    /// </summary>
    global::System.Threading.Tasks.Task DeleteAsync(
        string nonInsurancePayerRefundId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
