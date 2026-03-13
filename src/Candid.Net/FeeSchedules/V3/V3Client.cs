using System.Text.Json;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.FeeSchedules.V3;

public partial class V3Client : IV3Client
{
    private readonly RawClient _client;

    internal V3Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<MatchResult?>
    > GetMatchAsyncCore(
        string serviceLineId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                        "/api/fee-schedules/v3/service-line/{0}/match",
                        ValueConvert.ToPathParameterString(serviceLineId)
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
                var responseData = JsonUtils.Deserialize<MatchResult?>(responseBody)!;
                return new WithRawResponse<MatchResult?>()
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
        WithRawResponse<MatchTestResult>
    > TestMatchAsyncCore(
        string serviceLineId,
        string rateId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                        "/api/fee-schedules/v3/service-line/{0}/match/{1}",
                        ValueConvert.ToPathParameterString(serviceLineId),
                        ValueConvert.ToPathParameterString(rateId)
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
                var responseData = JsonUtils.Deserialize<MatchTestResult>(responseBody)!;
                return new WithRawResponse<MatchTestResult>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<RatesPage>> GetMultiAsyncCore(
        GetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 13)
            .Add("page_token", request.PageToken)
            .Add("limit", request.Limit)
            .Add("active_date", request.ActiveDate)
            .Add("payer_uuid", request.PayerUuid)
            .Add("organization_billing_provider_id", request.OrganizationBillingProviderId)
            .Add("states", request.States)
            .Add("zip_codes", request.ZipCodes)
            .Add("license_types", request.LicenseTypes)
            .Add("facility_type_codes", request.FacilityTypeCodes)
            .Add("network_types", request.NetworkTypes)
            .Add("payer_plan_group_ids", request.PayerPlanGroupIds)
            .Add("cpt_code", request.CptCode)
            .Add("modifiers", request.Modifiers)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Path = "/api/fee-schedules/v3",
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
                var responseData = JsonUtils.Deserialize<RatesPage>(responseBody)!;
                return new WithRawResponse<RatesPage>()
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
        WithRawResponse<DimensionsPage>
    > GetUniqueValuesForDimensionAsyncCore(
        GetUniqueDimensionValuesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 13)
            .Add("page_token", request.PageToken)
            .Add("limit", request.Limit)
            .Add("pivot_dimension", request.PivotDimension)
            .Add("payer_uuid", request.PayerUuid)
            .Add("organization_billing_provider_id", request.OrganizationBillingProviderId)
            .Add("states", request.States)
            .Add("zip_codes", request.ZipCodes)
            .Add("license_types", request.LicenseTypes)
            .Add("facility_type_codes", request.FacilityTypeCodes)
            .Add("network_types", request.NetworkTypes)
            .Add("payer_plan_group_ids", request.PayerPlanGroupIds)
            .Add("cpt_code", request.CptCode)
            .Add("modifiers", request.Modifiers)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Path = "/api/fee-schedules/v3/unique-dimension-values",
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
                var responseData = JsonUtils.Deserialize<DimensionsPage>(responseBody)!;
                return new WithRawResponse<DimensionsPage>()
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
        WithRawResponse<IEnumerable<Rate>>
    > GetRateHistoryAsyncCore(
        string rateId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                        "/api/fee-schedules/v3/{0}/history",
                        ValueConvert.ToPathParameterString(rateId)
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
                var responseData = JsonUtils.Deserialize<IEnumerable<Rate>>(responseBody)!;
                return new WithRawResponse<IEnumerable<Rate>>()
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
        WithRawResponse<IEnumerable<Rate>>
    > UploadFeeScheduleAsyncCore(
        FeeScheduleUploadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Path = "/api/fee-schedules/v3",
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
                var responseData = JsonUtils.Deserialize<IEnumerable<Rate>>(responseBody)!;
                return new WithRawResponse<IEnumerable<Rate>>()
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
        WithRawResponse<PayerThreshold>
    > GetPayerThresholdsDefaultAsyncCore(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Path = "/api/fee-schedules/v3/payer-threshold/default",
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
                var responseData = JsonUtils.Deserialize<PayerThreshold>(responseBody)!;
                return new WithRawResponse<PayerThreshold>()
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
        WithRawResponse<PayerThresholdsPage>
    > GetPayerThresholdsAsyncCore(
        PayerThresholdGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("payer_uuids", request.PayerUuids)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Path = "/api/fee-schedules/v3/payer-threshold",
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
                var responseData = JsonUtils.Deserialize<PayerThresholdsPage>(responseBody)!;
                return new WithRawResponse<PayerThresholdsPage>()
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
        WithRawResponse<PayerThreshold>
    > SetPayerThresholdAsyncCore(
        string payerUuid,
        PayerThreshold request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "/api/fee-schedules/v3/payer-threshold/{0}",
                        ValueConvert.ToPathParameterString(payerUuid)
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
                var responseData = JsonUtils.Deserialize<PayerThreshold>(responseBody)!;
                return new WithRawResponse<PayerThreshold>()
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
        WithRawResponse<int>
    > HardDeleteRatesAsyncCore(
        OptionalDimensions request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Path = "/api/fee-schedules/v3/hard-delete",
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
                var responseData = JsonUtils.Deserialize<int>(responseBody)!;
                return new WithRawResponse<int>()
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
        WithRawResponse<int>
    > HardDeleteRatesByIdsAsyncCore(
        HardDeleteRatesByIdsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Path = "/api/fee-schedules/v3/hard-delete-by-ids",
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
                var responseData = JsonUtils.Deserialize<int>(responseBody)!;
                return new WithRawResponse<int>()
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
    /// Gets the rate that matches a service line.  No result means no rate exists matching the service line's dimensions.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetMatchAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<MatchResult?> GetMatchAsync(
        string serviceLineId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<MatchResult?>(
            GetMatchAsyncCore(serviceLineId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Tests a service line against a rate to see if it matches.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.TestMatchAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    /// );
    /// </code></example>
    public WithRawResponseTask<MatchTestResult> TestMatchAsync(
        string serviceLineId,
        string rateId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<MatchTestResult>(
            TestMatchAsyncCore(serviceLineId, rateId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Gets a list of dimensions with their rates. The rates returned will always be the most recent versions of those rates.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetMultiAsync(new GetMultiRequest());
    /// </code></example>
    public WithRawResponseTask<RatesPage> GetMultiAsync(
        GetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<RatesPage>(
            GetMultiAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Gets unique values for a dimension based on other selection criteria. The response is a list of dimensions with your criteria and the unique values populated. This API is useful for driving pivots on dimension values.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetUniqueValuesForDimensionAsync(
    ///     new GetUniqueDimensionValuesRequest { PivotDimension = DimensionName.PayerUuid }
    /// );
    /// </code></example>
    public WithRawResponseTask<DimensionsPage> GetUniqueValuesForDimensionAsync(
        GetUniqueDimensionValuesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<DimensionsPage>(
            GetUniqueValuesForDimensionAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Gets every version of a rate.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetRateHistoryAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<IEnumerable<Rate>> GetRateHistoryAsync(
        string rateId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<Rate>>(
            GetRateHistoryAsyncCore(rateId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Uploads a new fee schedule.
    ///
    /// Each rate may either be totally new as qualified by it's dimensions or a new version for an existing rate.
    ///
    /// If adding a new version to an existing rate, the rate must be posted with the next version number (previous version + 1) or a EntityConflictError will
    /// be returned.
    ///
    /// Use the dry run flag to discover already existing rates and to run validations.  If validations for any rate fail, no rates will
    /// be saved to the system.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.UploadFeeScheduleAsync(
    ///     new FeeScheduleUploadRequest
    ///     {
    ///         DryRun = true,
    ///         Rates = new List&lt;RateUpload&gt;()
    ///         {
    ///             new RateUpload(
    ///                 new RateUpload.NewRate(
    ///                     new NewRate
    ///                     {
    ///                         Dimensions = new Dimensions
    ///                         {
    ///                             PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             States = new HashSet&lt;State&gt;() { State.Aa },
    ///                             ZipCodes = new HashSet&lt;string&gt;() { "zip_codes" },
    ///                             LicenseTypes = new HashSet&lt;LicenseType&gt;() { LicenseType.Md },
    ///                             FacilityTypeCodes = new HashSet&lt;FacilityTypeCode&gt;()
    ///                             {
    ///                                 FacilityTypeCode.Pharmacy,
    ///                             },
    ///                             NetworkTypes = new HashSet&lt;global::Candid.Net.Commons.NetworkType&gt;()
    ///                             {
    ///                                 global::Candid.Net.Commons.NetworkType.Ppo,
    ///                             },
    ///                             PayerPlanGroupIds = new HashSet&lt;string&gt;()
    ///                             {
    ///                                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             },
    ///                             CptCode = "cpt_code",
    ///                             Modifiers = new HashSet&lt;ProcedureModifier&gt;() { ProcedureModifier.Av },
    ///                         },
    ///                         Entries = new List&lt;RateEntry&gt;()
    ///                         {
    ///                             new RateEntry
    ///                             {
    ///                                 StartDate = new DateOnly(2023, 1, 15),
    ///                                 RateCents = 1,
    ///                                 IsDeactivated = true,
    ///                             },
    ///                             new RateEntry
    ///                             {
    ///                                 StartDate = new DateOnly(2023, 1, 15),
    ///                                 RateCents = 1,
    ///                                 IsDeactivated = true,
    ///                             },
    ///                         },
    ///                     }
    ///                 )
    ///             ),
    ///             new RateUpload(
    ///                 new RateUpload.NewRate(
    ///                     new NewRate
    ///                     {
    ///                         Dimensions = new Dimensions
    ///                         {
    ///                             PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             OrganizationBillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             States = new HashSet&lt;State&gt;() { State.Aa },
    ///                             ZipCodes = new HashSet&lt;string&gt;() { "zip_codes" },
    ///                             LicenseTypes = new HashSet&lt;LicenseType&gt;() { LicenseType.Md },
    ///                             FacilityTypeCodes = new HashSet&lt;FacilityTypeCode&gt;()
    ///                             {
    ///                                 FacilityTypeCode.Pharmacy,
    ///                             },
    ///                             NetworkTypes = new HashSet&lt;global::Candid.Net.Commons.NetworkType&gt;()
    ///                             {
    ///                                 global::Candid.Net.Commons.NetworkType.Ppo,
    ///                             },
    ///                             PayerPlanGroupIds = new HashSet&lt;string&gt;()
    ///                             {
    ///                                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                             },
    ///                             CptCode = "cpt_code",
    ///                             Modifiers = new HashSet&lt;ProcedureModifier&gt;() { ProcedureModifier.Av },
    ///                         },
    ///                         Entries = new List&lt;RateEntry&gt;()
    ///                         {
    ///                             new RateEntry
    ///                             {
    ///                                 StartDate = new DateOnly(2023, 1, 15),
    ///                                 RateCents = 1,
    ///                                 IsDeactivated = true,
    ///                             },
    ///                             new RateEntry
    ///                             {
    ///                                 StartDate = new DateOnly(2023, 1, 15),
    ///                                 RateCents = 1,
    ///                                 IsDeactivated = true,
    ///                             },
    ///                         },
    ///                     }
    ///                 )
    ///             ),
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<IEnumerable<Rate>> UploadFeeScheduleAsync(
        FeeScheduleUploadRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<Rate>>(
            UploadFeeScheduleAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Soft deletes a rate from the system.  Only the most recent version of a rate can be deleted.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.DeleteRateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32", 1);
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteRateAsync(
        string rateId,
        int version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "/api/fee-schedules/v3/{0}/{1}",
                        ValueConvert.ToPathParameterString(rateId),
                        ValueConvert.ToPathParameterString(version)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
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
    /// Gets the default payer threshold
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetPayerThresholdsDefaultAsync();
    /// </code></example>
    public WithRawResponseTask<PayerThreshold> GetPayerThresholdsDefaultAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PayerThreshold>(
            GetPayerThresholdsDefaultAsyncCore(options, cancellationToken)
        );
    }

    /// <summary>
    /// Gets a list of payers and thresholds by their uuids
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.GetPayerThresholdsAsync(
    ///     new PayerThresholdGetRequest { PayerUuids = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"] }
    /// );
    /// </code></example>
    public WithRawResponseTask<PayerThresholdsPage> GetPayerThresholdsAsync(
        PayerThresholdGetRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PayerThresholdsPage>(
            GetPayerThresholdsAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Sets the threshold information for a payer
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.SetPayerThresholdAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new PayerThreshold { DisablePaidIncorrectly = true }
    /// );
    /// </code></example>
    public WithRawResponseTask<PayerThreshold> SetPayerThresholdAsync(
        string payerUuid,
        PayerThreshold request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PayerThreshold>(
            SetPayerThresholdAsyncCore(payerUuid, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Hard deletes rates from the system that match the provided dimensions.  This is a destructive operation and cannot be undone.  If an empty dimensions object is provided, all rates will be hard deleted.  The maximum number of rates this API will delete at a time is 10000.  Returns the number of rates deleted and if that number is the maximum, the caller should call this API again to continue deleting rates.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.HardDeleteRatesAsync(
    ///     new OptionalDimensions
    ///     {
    ///         States = new HashSet&lt;State&gt;() { State.Aa },
    ///         ZipCodes = new HashSet&lt;string&gt;() { "zip_codes" },
    ///         LicenseTypes = new HashSet&lt;LicenseType&gt;() { LicenseType.Md },
    ///         FacilityTypeCodes = new HashSet&lt;FacilityTypeCode&gt;() { FacilityTypeCode.Pharmacy },
    ///         NetworkTypes = new HashSet&lt;global::Candid.Net.Commons.NetworkType&gt;()
    ///         {
    ///             global::Candid.Net.Commons.NetworkType.Ppo,
    ///         },
    ///         PayerPlanGroupIds = new HashSet&lt;string&gt;() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
    ///         Modifiers = new HashSet&lt;ProcedureModifier&gt;() { ProcedureModifier.Av },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<int> HardDeleteRatesAsync(
        OptionalDimensions request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<int>(
            HardDeleteRatesAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Hard deletes specific rates from the system by their IDs. This is a destructive operation and cannot be undone. Limited to 100 rate IDs maximum per request. For bulk deletion of more than 100 rates, use the hard_delete_rates endpoint with dimension filters. Returns the number of rates deleted.
    /// </summary>
    /// <example><code>
    /// await client.FeeSchedules.V3.HardDeleteRatesByIdsAsync(
    ///     new HardDeleteRatesByIdsRequest
    ///     {
    ///         RateIds = new List&lt;string&gt;()
    ///         {
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<int> HardDeleteRatesByIdsAsync(
        HardDeleteRatesByIdsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<int>(
            HardDeleteRatesByIdsAsyncCore(request, options, cancellationToken)
        );
    }
}
