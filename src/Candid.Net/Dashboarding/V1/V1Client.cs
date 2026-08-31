using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;

namespace Candid.Net.Dashboarding.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<MetricsQueryResponse>
    > QueryMetricsAsyncCore(
        IEnumerable<MetricQuery> request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/dashboarding/v1/metrics",
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<MetricsQueryResponse>(responseBody)!;
                return new WithRawResponse<MetricsQueryResponse>()
                {
                    Data = responseData,
                    RawResponse = new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e,
                    rawResponse: new global::Candid.Net.RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    }
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody,
                rawResponse: new global::Candid.Net.RawResponse()
                {
                    StatusCode = response.Raw.StatusCode,
                    Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                    Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                }
            );
        }
    }

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
    /// <example><code>
    /// await client.Dashboarding.V1.QueryMetricsAsync(
    ///     new List&lt;MetricQuery&gt;()
    ///     {
    ///         new MetricQuery { Metric = MetricName.PatientTotalBalanceV1 },
    ///         new MetricQuery { Metric = MetricName.PatientTotalBalanceV1 },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<MetricsQueryResponse> QueryMetricsAsync(
        IEnumerable<MetricQuery> request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<MetricsQueryResponse>(
            QueryMetricsAsyncCore(request, options, cancellationToken)
        );
    }
}
