using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.NonInsurancePayers.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<NonInsurancePayer>
    > CreateAsyncCore(
        CreateNonInsurancePayerRequest request,
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
                    Path = "/api/non-insurance-payers/v1",
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
                var responseData = JsonUtils.Deserialize<NonInsurancePayer>(responseBody)!;
                return new WithRawResponse<NonInsurancePayer>()
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
        WithRawResponse<NonInsurancePayer>
    > ToggleEnablementAsyncCore(
        string nonInsurancePayerId,
        ToggleNonInsurancePayerEnablementRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "/api/non-insurance-payers/v1/{0}/toggle_enablement",
                        ValueConvert.ToPathParameterString(nonInsurancePayerId)
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
                var responseData = JsonUtils.Deserialize<NonInsurancePayer>(responseBody)!;
                return new WithRawResponse<NonInsurancePayer>()
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
        WithRawResponse<NonInsurancePayerPage>
    > GetMultiAsyncCore(
        GetMultiNonInsurancePayersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 9)
            .Add("name", request.Name)
            .Add("category", request.Category)
            .Add("categories_exact", request.CategoriesExact)
            .Add("clinical_trial_ids", request.ClinicalTrialIds)
            .Add("enabled", request.Enabled)
            .Add("sort", request.Sort)
            .Add("sort_direction", request.SortDirection)
            .Add("limit", request.Limit)
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
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/non-insurance-payers/v1",
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
                var responseData = JsonUtils.Deserialize<NonInsurancePayerPage>(responseBody)!;
                return new WithRawResponse<NonInsurancePayerPage>()
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
        WithRawResponse<NonInsurancePayerCategoriesPage>
    > GetCategoriesAsyncCore(
        GetNonInsurancePayersCategoriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 3)
            .Add("search_term", request.SearchTerm)
            .Add("limit", request.Limit)
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
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/non-insurance-payers/v1/categories",
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
                var responseData = JsonUtils.Deserialize<NonInsurancePayerCategoriesPage>(
                    responseBody
                )!;
                return new WithRawResponse<NonInsurancePayerCategoriesPage>()
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
        WithRawResponse<NonInsurancePayer>
    > GetAsyncCore(
        string nonInsurancePayerId,
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
                        "/api/non-insurance-payers/v1/{0}",
                        ValueConvert.ToPathParameterString(nonInsurancePayerId)
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
                var responseData = JsonUtils.Deserialize<NonInsurancePayer>(responseBody)!;
                return new WithRawResponse<NonInsurancePayer>()
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
        WithRawResponse<NonInsurancePayer>
    > UpdateAsyncCore(
        string nonInsurancePayerId,
        NonInsurancePayerUpdateRequest request,
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "/api/non-insurance-payers/v1/{0}",
                        ValueConvert.ToPathParameterString(nonInsurancePayerId)
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
                var responseData = JsonUtils.Deserialize<NonInsurancePayer>(responseBody)!;
                return new WithRawResponse<NonInsurancePayer>()
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

    /// <example><code>
    /// await client.NonInsurancePayers.V1.CreateAsync(
    ///     new CreateNonInsurancePayerRequest { Name = "name" }
    /// );
    /// </code></example>
    public WithRawResponseTask<NonInsurancePayer> CreateAsync(
        CreateNonInsurancePayerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<NonInsurancePayer>(
            CreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.NonInsurancePayers.V1.ToggleEnablementAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ToggleNonInsurancePayerEnablementRequest { Enabled = true }
    /// );
    /// </code></example>
    public WithRawResponseTask<NonInsurancePayer> ToggleEnablementAsync(
        string nonInsurancePayerId,
        ToggleNonInsurancePayerEnablementRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<NonInsurancePayer>(
            ToggleEnablementAsyncCore(nonInsurancePayerId, request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.NonInsurancePayers.V1.GetMultiAsync(new GetMultiNonInsurancePayersRequest());
    /// </code></example>
    public WithRawResponseTask<NonInsurancePayerPage> GetMultiAsync(
        GetMultiNonInsurancePayersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<NonInsurancePayerPage>(
            GetMultiAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Returns a paginated list of all non-insurance payer categories.
    ///
    /// Non-insurance payer categories are simply strings and are not stored as a
    /// separate object in Candid. They are created when added to at least one
    /// non-insurance payer's `category` field and are deleted when there are no
    /// longer any non-insurance payers that contain them.
    /// </summary>
    /// <example><code>
    /// await client.NonInsurancePayers.V1.GetCategoriesAsync(new GetNonInsurancePayersCategoriesRequest());
    /// </code></example>
    public WithRawResponseTask<NonInsurancePayerCategoriesPage> GetCategoriesAsync(
        GetNonInsurancePayersCategoriesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<NonInsurancePayerCategoriesPage>(
            GetCategoriesAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.NonInsurancePayers.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<NonInsurancePayer> GetAsync(
        string nonInsurancePayerId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<NonInsurancePayer>(
            GetAsyncCore(nonInsurancePayerId, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.NonInsurancePayers.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new NonInsurancePayerUpdateRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<NonInsurancePayer> UpdateAsync(
        string nonInsurancePayerId,
        NonInsurancePayerUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<NonInsurancePayer>(
            UpdateAsyncCore(nonInsurancePayerId, request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.NonInsurancePayers.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteAsync(
        string nonInsurancePayerId,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "/api/non-insurance-payers/v1/{0}",
                        ValueConvert.ToPathParameterString(nonInsurancePayerId)
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
}
