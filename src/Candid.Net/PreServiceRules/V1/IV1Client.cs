using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PreServiceRules.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Submit a representation of an encounter to the Candid rules engine. Note that this encounter will not be created in Candid.
    /// Returns a run_id that can be polled via GET /runs/{run_id} to retrieve the results once complete.
    /// </summary>
    WithRawResponseTask<PreServiceRunCreateResponse> CreateEncounterRunAsync(
        PreServiceEncounterRunCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve the result of a pre-service run. This endpoint supports long-polling.
    /// </summary>
    WithRawResponseTask<PreServiceRun> GetRunAsync(
        string runId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// List the pre-service pipelines available to the authenticated organization.
    /// </summary>
    WithRawResponseTask<IEnumerable<PreServicePipelineSummary>> GetPipelinesAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
