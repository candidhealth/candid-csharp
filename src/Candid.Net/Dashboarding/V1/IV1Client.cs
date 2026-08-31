using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.Dashboarding.V1;

public partial interface IV1Client
{
    /// <summary>
    /// Retrieves values for one or more metrics. Each metric is computed independently, so a
    /// metric that cannot be resolved returns an `error` on its own result rather than failing
    /// the request.
    ///
    /// Each query reads current state by default. Count metrics also accept a `yesterday`
    /// snapshot, so day-over-day change is computed by querying both and taking the difference.
    ///
    /// See the [Metrics Reference](/docs/dashboarding-metrics) for the full catalog, including
    /// value types and staleness SLAs.
    /// </summary>
    WithRawResponseTask<MetricsQueryResponse> QueryMetricsAsync(
        IEnumerable<MetricQuery> request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    );
}
