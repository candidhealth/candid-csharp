using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ServiceLines.V2;

public partial interface IV2Client
{
    WithRawResponseTask<ServiceLine> CreateAsync(
        ServiceLineCreateStandalone request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ServiceLine> CreateUniversalAsync(
        UniversalServiceLineCreateStandalone request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ServiceLine> UpdateUniversalAsync(
        string serviceLineId,
        UniversalServiceLineUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    WithRawResponseTask<ServiceLine> UpdateAsync(
        string serviceLineId,
        ServiceLineUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    global::System.Threading.Tasks.Task DeleteAsync(
        string serviceLineId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Creates or updates a service line based on the combination of external_id and claim_id.
    ///
    /// - If a service line with the given external_id and claim_id already exists for the organization, it will be updated.
    /// - If no service line exists with that combination, a new service line will be created with the provided external_id.
    /// </summary>
    WithRawResponseTask<ServiceLine> UpsertByExternalIdAsync(
        string externalId,
        ServiceLineCreateStandalone request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
