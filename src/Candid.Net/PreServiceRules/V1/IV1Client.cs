using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PreServiceRules.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Submit a representation of an encounter to the Candid rules engine. Note that this encounter will not be created in Candid.
    /// Returns a run_id that can be polled via GET /runs/{run_id} to retrieve the results once complete.
    ///
    /// Retries:
    /// - 503 Service Unavailable is temporary. Retry with exponential backoff and jitter, wait at least the number of seconds in the Retry-After header, and send the same idempotency_key so the retry is deduplicated. Stop after 5 attempts.
    /// - 422 Unprocessable Entity means the request is invalid. Resending it unchanged returns the same error; fix the request first.
    /// </summary>
    WithRawResponseTask<string> CreateEncounterRunAsync(
        PreServiceEncounterRunCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );

    /// <summary>
    /// Retrieve the result of a pre-service run. This endpoint supports long-polling.
    /// </summary>
    WithRawResponseTask<PreServiceRun> GetRunAsync(
        string runId,
        GetPreServiceRunRequest request,
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
