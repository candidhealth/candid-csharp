using global::Candid.Net;
using global::Candid.Net.Core;
using global::System.Text.Json;

namespace Candid.Net.ExternalConsolidatedRemit.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<ExternalConsolidatedRemitEraPaymentsResponse>
    > GetEraPaymentsAsyncCore(
        string consolidatedRemitId,
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
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/api/external-consolidated-remit/v1/{0}/era-payments",
                        ValueConvert.ToPathParameterString(consolidatedRemitId)
                    ),
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
                var responseData =
                    JsonUtils.Deserialize<ExternalConsolidatedRemitEraPaymentsResponse>(
                        responseBody
                    )!;
                return new WithRawResponse<ExternalConsolidatedRemitEraPaymentsResponse>()
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

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<ExternalConsolidatedRemitTransactionPage>
    > GetTransactionsAsyncCore(
        string consolidatedRemitId,
        GetExternalConsolidatedRemitTransactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 5)
            .Add("page_token", request.PageToken)
            .Add("limit", request.Limit)
            .Add("era_payment_id", request.EraPaymentId)
            .Add("transaction_id", request.TransactionId)
            .Add("transaction_type", request.TransactionType)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
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
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/api/external-consolidated-remit/v1/{0}/transactions",
                        ValueConvert.ToPathParameterString(consolidatedRemitId)
                    ),
                    QueryString = _queryString,
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
                var responseData = JsonUtils.Deserialize<ExternalConsolidatedRemitTransactionPage>(
                    responseBody
                )!;
                return new WithRawResponse<ExternalConsolidatedRemitTransactionPage>()
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
    /// Returns metadata for every ERA payment (835 transaction set) associated with a
    /// consolidated remit, including the source ERA document for each, and indicates which ERA
    /// payment is currently elected as primary.
    /// </summary>
    /// <example><code>
    /// await client.ExternalConsolidatedRemit.V1.GetEraPaymentsAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    /// );
    /// </code></example>
    public WithRawResponseTask<ExternalConsolidatedRemitEraPaymentsResponse> GetEraPaymentsAsync(
        string consolidatedRemitId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ExternalConsolidatedRemitEraPaymentsResponse>(
            GetEraPaymentsAsyncCore(consolidatedRemitId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Paginated, combined list of InsurancePayment and InsuranceAdjustment transactions posted
    /// from a consolidated remit's ERA payments - covering service-payment-driven and
    /// payment-bundle-driven activity of both kinds, and both the posted and voided sides of each
    /// (see is_void). Each item is discriminated by type; fields common to both transaction types
    /// are always present alongside the type-specific ones. One combined, single-cursor
    /// pagination stream rather than two separate endpoints - filter to a single type with
    /// transaction_type if you only care about one.
    /// </summary>
    /// <example><code>
    /// await client.ExternalConsolidatedRemit.V1.GetTransactionsAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new GetExternalConsolidatedRemitTransactionsRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<ExternalConsolidatedRemitTransactionPage> GetTransactionsAsync(
        string consolidatedRemitId,
        GetExternalConsolidatedRemitTransactionsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ExternalConsolidatedRemitTransactionPage>(
            GetTransactionsAsyncCore(consolidatedRemitId, request, options, cancellationToken)
        );
    }
}
