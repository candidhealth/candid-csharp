using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PayerGroups.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns all payer groups matching filter criteria.
    /// </summary>
    WithRawResponseTask<PayerGroupPage> GetMultiAsync(
        PayerGroupGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Return a payer group with a given ID.
    /// </summary>
    WithRawResponseTask<PayerGroup> GetAsync(
        string payerGroupId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Create a payer group. When `payer_plan_group_ids` is provided, moves those plans into
    /// the new group atomically (same transaction). On any failure the group is not created
    /// and no plans are moved.
    /// </summary>
    WithRawResponseTask<PayerGroup> CreateAsync(
        CreatePayerGroupRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Update the name of a payer group
    /// </summary>
    WithRawResponseTask<PayerGroup> UpdateAsync(
        string payerGroupId,
        MutablePayerGroup request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
