using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Returns all write-offs satisfying the search criteria.
    /// </summary>
    WithRawResponseTask<WriteOffsPage> GetMultiAsync(
        GetMultiWriteOffsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieves a previously created write off by its `write_off_id`.
    /// </summary>
    WithRawResponseTask<WriteOff> GetAsync(
        string writeOffId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates one or many write-offs applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    WithRawResponseTask<CreateWriteOffsResponse> CreateAsync(
        CreateWriteOffsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reverts a write off given a `write_off_id`.
    /// </summary>
    WithRawResponseTask<WriteOff> RevertAsync(
        string writeOffId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reverts an Insurance Balance Adjustment given an `adjustment_id`
    /// </summary>
    WithRawResponseTask<WriteOff> RevertInsuranceBalanceAdjustmentAsync(
        string adjustmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Reverts an ERA-originated Insurance Balance Adjustment given an `adjustment_id`
    /// </summary>
    WithRawResponseTask<string> RevertEraOriginatedInsuranceBalanceAdjustmentAsync(
        string adjustmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
