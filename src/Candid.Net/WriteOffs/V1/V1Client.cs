using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.WriteOffs.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<WriteOffsPage>
    > GetMultiAsyncCore(
        GetMultiWriteOffsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 10)
            .Add("limit", request.Limit)
            .Add("patient_external_id", request.PatientExternalId)
            .Add("payer_uuid", request.PayerUuid)
            .Add("service_line_id", request.ServiceLineId)
            .Add("claim_id", request.ClaimId)
            .Add("billing_provider_id", request.BillingProviderId)
            .Add("sort", request.Sort)
            .Add("sort_direction", request.SortDirection)
            .Add("page_token", request.PageToken)
            .Add("account_types", request.AccountTypes)
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
                    Path = "/api/write-offs/v1",
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
                var responseData = JsonUtils.Deserialize<WriteOffsPage>(responseBody)!;
                return new WithRawResponse<WriteOffsPage>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<WriteOff>> GetAsyncCore(
        string writeOffId,
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
                        "/api/write-offs/v1/{0}",
                        ValueConvert.ToPathParameterString(writeOffId)
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
                var responseData = JsonUtils.Deserialize<WriteOff>(responseBody)!;
                return new WithRawResponse<WriteOff>()
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
        WithRawResponse<CreateWriteOffsResponse>
    > CreateAsyncCore(
        CreateWriteOffsRequest request,
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
                    Path = "/api/write-offs/v1",
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
                var responseData = JsonUtils.Deserialize<CreateWriteOffsResponse>(responseBody)!;
                return new WithRawResponse<CreateWriteOffsResponse>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<WriteOff>> RevertAsyncCore(
        string writeOffId,
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
                    Path = string.Format(
                        "/api/write-offs/v1/{0}/revert",
                        ValueConvert.ToPathParameterString(writeOffId)
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
                var responseData = JsonUtils.Deserialize<WriteOff>(responseBody)!;
                return new WithRawResponse<WriteOff>()
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
        WithRawResponse<WriteOff>
    > RevertInsuranceBalanceAdjustmentAsyncCore(
        string adjustmentId,
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
                    Path = string.Format(
                        "/api/write-offs/v1/{0}/revert",
                        ValueConvert.ToPathParameterString(adjustmentId)
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
                var responseData = JsonUtils.Deserialize<WriteOff>(responseBody)!;
                return new WithRawResponse<WriteOff>()
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
        WithRawResponse<string>
    > RevertEraOriginatedInsuranceBalanceAdjustmentAsyncCore(
        string adjustmentId,
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
                    Path = string.Format(
                        "/api/write-offs/v1/{0}/revert-era-originated",
                        ValueConvert.ToPathParameterString(adjustmentId)
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
                var responseData = JsonUtils.Deserialize<string>(responseBody)!;
                return new WithRawResponse<string>()
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
    /// Returns all write-offs satisfying the search criteria.
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.GetMultiAsync(new GetMultiWriteOffsRequest());
    /// </code></example>
    public WithRawResponseTask<WriteOffsPage> GetMultiAsync(
        GetMultiWriteOffsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<WriteOffsPage>(
            GetMultiAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Retrieves a previously created write off by its `write_off_id`.
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<WriteOff> GetAsync(
        string writeOffId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<WriteOff>(
            GetAsyncCore(writeOffId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Creates one or many write-offs applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.CreateAsync(
    ///     new CreateWriteOffsRequest
    ///     {
    ///         WriteOffs = new List&lt;WriteOffCreate&gt;()
    ///         {
    ///             new WriteOffCreate(
    ///                 new global::Candid.Net.WriteOffs.V1.WriteOffCreate.Patient(
    ///                     new PatientWriteOffCreate
    ///                     {
    ///                         WriteOffTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///                         WriteOffReason = PatientWriteOffReason.SmallBalance,
    ///                         ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                         AmountCents = 1,
    ///                     }
    ///                 )
    ///             ),
    ///             new WriteOffCreate(
    ///                 new global::Candid.Net.WriteOffs.V1.WriteOffCreate.Patient(
    ///                     new PatientWriteOffCreate
    ///                     {
    ///                         WriteOffTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///                         WriteOffReason = PatientWriteOffReason.SmallBalance,
    ///                         ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                         AmountCents = 1,
    ///                     }
    ///                 )
    ///             ),
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<CreateWriteOffsResponse> CreateAsync(
        CreateWriteOffsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<CreateWriteOffsResponse>(
            CreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Reverts a write off given a `write_off_id`.
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.RevertAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<WriteOff> RevertAsync(
        string writeOffId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<WriteOff>(
            RevertAsyncCore(writeOffId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Reverts an Insurance Balance Adjustment given an `adjustment_id`
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.RevertInsuranceBalanceAdjustmentAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    /// );
    /// </code></example>
    public WithRawResponseTask<WriteOff> RevertInsuranceBalanceAdjustmentAsync(
        string adjustmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<WriteOff>(
            RevertInsuranceBalanceAdjustmentAsyncCore(adjustmentId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Reverts an ERA-originated Insurance Balance Adjustment given an `adjustment_id`
    /// </summary>
    /// <example><code>
    /// await client.WriteOffs.V1.RevertEraOriginatedInsuranceBalanceAdjustmentAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    /// );
    /// </code></example>
    public WithRawResponseTask<string> RevertEraOriginatedInsuranceBalanceAdjustmentAsync(
        string adjustmentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<string>(
            RevertEraOriginatedInsuranceBalanceAdjustmentAsyncCore(
                adjustmentId,
                options,
                cancellationToken
            )
        );
    }
}
