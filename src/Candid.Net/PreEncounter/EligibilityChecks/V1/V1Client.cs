using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<EligibilityCheck>
    > PostAsyncCore(
        EligibilityRequest request,
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
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Post,
                    Path = "/eligibility-checks/v1",
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
                var responseData = JsonUtils.Deserialize<EligibilityCheck>(responseBody)!;
                return new WithRawResponse<EligibilityCheck>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
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
                    e
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
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<BatchEligibilityResponse>
    > BatchAsyncCore(
        IEnumerable<EligibilityRequest> request,
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
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Post,
                    Path = "/eligibility-checks/v1/batch",
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
                var responseData = JsonUtils.Deserialize<BatchEligibilityResponse>(responseBody)!;
                return new WithRawResponse<BatchEligibilityResponse>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
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
                    e
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
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<EligibilityCheckPage>
    > PollBatchAsyncCore(
        string batchId,
        BatchEligibilityPollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("page_token", request.PageToken)
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
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/eligibility-checks/v1/batch/{0}",
                        ValueConvert.ToPathParameterString(batchId)
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
                var responseData = JsonUtils.Deserialize<EligibilityCheckPage>(responseBody)!;
                return new WithRawResponse<EligibilityCheckPage>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
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
                    e
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
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<PayerSearchResponse>
    > PayerSearchAsyncCore(
        PayerSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 3)
            .Add("page_size", request.PageSize)
            .Add("page_token", request.PageToken)
            .Add("query", request.Query)
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
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/eligibility-checks/v1/payer/search",
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
                var responseData = JsonUtils.Deserialize<PayerSearchResponse>(responseBody)!;
                return new WithRawResponse<PayerSearchResponse>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
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
                    e
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
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<IEnumerable<EligibilityRecommendation>>
    > RecommendationAsyncCore(
        EligibilityRecommendationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("filters", request.Filters)
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
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/eligibility-checks/v1/recommendation",
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
                var responseData = JsonUtils.Deserialize<IEnumerable<EligibilityRecommendation>>(
                    responseBody
                )!;
                return new WithRawResponse<IEnumerable<EligibilityRecommendation>>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
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
                    e
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
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<EligibilityRecommendation>
    > CreateRecommendationAsyncCore(
        PostEligibilityRecommendationRequest request,
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
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Post,
                    Path = "/eligibility-checks/v1/recommendation",
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
                var responseData = JsonUtils.Deserialize<EligibilityRecommendation>(responseBody)!;
                return new WithRawResponse<EligibilityRecommendation>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
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
                    e
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
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<EligibilityRecommendation>
    > VoteRecommendationAsyncCore(
        string recommendationId,
        string version,
        Vote request,
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
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "/eligibility-checks/v1/recommendation/{0}/{1}/vote",
                        ValueConvert.ToPathParameterString(recommendationId),
                        ValueConvert.ToPathParameterString(version)
                    ),
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
                var responseData = JsonUtils.Deserialize<EligibilityRecommendation>(responseBody)!;
                return new WithRawResponse<EligibilityRecommendation>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
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
                    e
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
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<EligibilityCheckPage>
    > GetMultiAsyncCore(
        EligibilityChecksGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 8)
            .Add("page_token", request.PageToken)
            .Add("limit", request.Limit)
            .Add("subscriber_member_id", request.SubscriberMemberId)
            .Add("payer_id", request.PayerId)
            .Add("provider_npi", request.ProviderNpi)
            .Add("date_of_service", request.DateOfService)
            .Add("initiated_at_min", request.InitiatedAtMin)
            .Add("initiated_at_max", request.InitiatedAtMax)
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
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/eligibility-checks/v1/get-multi/",
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
                var responseData = JsonUtils.Deserialize<EligibilityCheckPage>(responseBody)!;
                return new WithRawResponse<EligibilityCheckPage>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
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
                    e
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
                responseBody
            );
        }
    }

    /// <summary>
    /// Sends real-time eligibility checks to payers through Stedi.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.PostAsync(
    ///     new EligibilityRequest
    ///     {
    ///         PayerId = "payer_id",
    ///         Provider = new IndividualProvider { Npi = "npi" },
    ///         Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<EligibilityCheck> PostAsync(
        EligibilityRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<EligibilityCheck>(
            PostAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Sends a batch of eligibility checks to payers through Stedi.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.BatchAsync(
    ///     new List&lt;EligibilityRequest&gt;()
    ///     {
    ///         new EligibilityRequest
    ///         {
    ///             PayerId = "payer_id",
    ///             Provider = new IndividualProvider { Npi = "npi" },
    ///             Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
    ///         },
    ///         new EligibilityRequest
    ///         {
    ///             PayerId = "payer_id",
    ///             Provider = new IndividualProvider { Npi = "npi" },
    ///             Subscriber = new MemberInfo { FirstName = "first_name", LastName = "last_name" },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<BatchEligibilityResponse> BatchAsync(
        IEnumerable<EligibilityRequest> request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<BatchEligibilityResponse>(
            BatchAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Polls the status of a batch eligibility check.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.PollBatchAsync(
    ///     "batch_id",
    ///     new BatchEligibilityPollRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<EligibilityCheckPage> PollBatchAsync(
        string batchId,
        BatchEligibilityPollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<EligibilityCheckPage>(
            PollBatchAsyncCore(batchId, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Searches for payers that match the query parameters.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.PayerSearchAsync(new PayerSearchRequest());
    /// </code></example>
    public WithRawResponseTask<PayerSearchResponse> PayerSearchAsync(
        PayerSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PayerSearchResponse>(
            PayerSearchAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Gets recommendation for eligibility checks based on filters. This endpoint will retrieve all the latest eligibility recommendations for each
    /// eligibility recommendation type for the given filters. If you want to get a specific recommendation type, you can use the `type` query parameter.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.RecommendationAsync(
    ///     new EligibilityRecommendationRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<IEnumerable<EligibilityRecommendation>> RecommendationAsync(
        EligibilityRecommendationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<EligibilityRecommendation>>(
            RecommendationAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Create an eligibiilty recommendation based on the request.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.CreateRecommendationAsync(
    ///     new PostEligibilityRecommendationRequest
    ///     {
    ///         EligibilityCheckId = "eligibility_check_id",
    ///         Patient = new EligibilityRecommendationPatientInfo(),
    ///         Recommendation = new EligibilityRecommendationPayload(
    ///             new EligibilityRecommendationPayload.MedicareAdvantage(
    ///                 new MedicareAdvantageRecommendation
    ///                 {
    ///                     Payload = new MedicareAdvantageRecommendationPayload(),
    ///                 }
    ///             )
    ///         ),
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<EligibilityRecommendation> CreateRecommendationAsync(
        PostEligibilityRecommendationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<EligibilityRecommendation>(
            CreateRecommendationAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Submit user feedback on an eligibility recommendation. The path must contain the next version number to prevent race conditions. For example, if the current version of the recommendation is n, you will need to send a request to this endpoint with `/{recommendation_id}/{n+1}/vote` to update the vote.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.VoteRecommendationAsync(
    ///     "recommendation_id",
    ///     "version",
    ///     new Vote { UserId = "user_id", Value = VoteValue.Upvote }
    /// );
    /// </code></example>
    public WithRawResponseTask<EligibilityRecommendation> VoteRecommendationAsync(
        string recommendationId,
        string version,
        Vote request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<EligibilityRecommendation>(
            VoteRecommendationAsyncCore(
                recommendationId,
                version,
                request,
                options,
                cancellationToken
            )
        );
    }

    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.GetMultiAsync(
    ///     new EligibilityChecksGetMultiRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<EligibilityCheckPage> GetMultiAsync(
        EligibilityChecksGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<EligibilityCheckPage>(
            GetMultiAsyncCore(request, options, cancellationToken)
        );
    }
}
