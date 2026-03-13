using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PayerPlanGroups.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns all payer plan groups matching filter criteria.
    /// </summary>
    WithRawResponseTask<PayerPlanGroupPage> GetMultiAsync(
        PayerPlanGroupGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return a plan group with a given ID.
    /// </summary>
    WithRawResponseTask<PayerPlanGroup> GetAsync(
        string payerPlanGroupId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a payer plan group
    /// </summary>
    WithRawResponseTask<PayerPlanGroup> CreateAsync(
        MutablePayerPlanGroup request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update any of the fields on a payer plan group
    /// </summary>
    WithRawResponseTask<PayerPlanGroup> UpdateAsync(
        string payerPlanGroupId,
        MutablePayerPlanGroup request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Marks the payer plan group as deactivated
    /// </summary>
    WithRawResponseTask<PayerPlanGroup> DeactivateAsync(
        string payerPlanGroupId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
