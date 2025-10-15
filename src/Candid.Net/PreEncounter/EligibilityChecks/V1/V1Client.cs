using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.EligibilityChecks.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
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
    public async System.Threading.Tasks.Task<EligibilityCheck> PostAsync(
        EligibilityRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Post,
                    Path = "/eligibility-checks/v1",
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<EligibilityCheck>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
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
    public async System.Threading.Tasks.Task<BatchEligibilityResponse> BatchAsync(
        IEnumerable<EligibilityRequest> request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Post,
                    Path = "/eligibility-checks/v1/batch",
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<BatchEligibilityResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
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
    public async System.Threading.Tasks.Task<EligibilityCheckPage> PollBatchAsync(
        string batchId,
        BatchEligibilityPollRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
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
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<EligibilityCheckPage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Searches for payers that match the query parameters.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.PayerSearchAsync(new PayerSearchRequest());
    /// </code></example>
    public async System.Threading.Tasks.Task<PayerSearchResponse> PayerSearchAsync(
        PayerSearchRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.PageSize != null)
        {
            _query["page_size"] = request.PageSize.Value.ToString();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Query != null)
        {
            _query["query"] = request.Query;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/eligibility-checks/v1/payer/search",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<PayerSearchResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Gets recommendation for eligibility checks based on the request.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.EligibilityChecks.V1.RecommendationAsync(
    ///     new EligibilityRecommendationRequest()
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<
        IEnumerable<EligibilityRecommendation>
    > RecommendationAsync(
        EligibilityRecommendationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Filters != null)
        {
            _query["filters"] = request.Filters;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/eligibility-checks/v1/recommendation",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<IEnumerable<EligibilityRecommendation>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
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
    public async System.Threading.Tasks.Task<EligibilityRecommendation> CreateRecommendationAsync(
        PostEligibilityRecommendationRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Post,
                    Path = "/eligibility-checks/v1/recommendation",
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<EligibilityRecommendation>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
