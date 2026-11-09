using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PayerPlanGroups.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns all payer plans matching filter criteria.
    /// </summary>
    WithRawResponseTask<PayerPlanGroupPage> GetMultiAsync(
        PayerPlanGroupGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return a payer plan with a given ID.
    /// </summary>
    WithRawResponseTask<PayerPlanGroup> GetAsync(
        string payerPlanGroupId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a payer plan.
    ///
    /// Note: If your org does not have access to Payer Plans, you cannot use APIs to create Payer Plans.
    /// </summary>
    WithRawResponseTask<PayerPlanGroup> CreateAsync(
        MutablePayerPlanGroup request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update any of the fields on a payer plan.
    ///
    /// Note: If your org does not have access to Payer Plans, you cannot use APIs to update Payer Plans.
    /// </summary>
    WithRawResponseTask<PayerPlanGroup> UpdateAsync(
        string payerPlanGroupId,
        MutablePayerPlanGroup request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Marks the payer plan as deactivated.
    ///
    /// Note: If your org does not have access to Payer Plans, you cannot use APIs to deactivate Payer Plans.
    /// </summary>
    WithRawResponseTask<PayerPlanGroup> DeactivateAsync(
        string payerPlanGroupId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
