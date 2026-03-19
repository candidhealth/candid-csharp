using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.PatientRefunds.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<PatientRefundsPage>
    > GetMultiAsyncCore(
        GetMultiPatientRefundsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 11)
            .Add("limit", request.Limit)
            .Add("patient_external_id", request.PatientExternalId)
            .Add("claim_id", request.ClaimId)
            .Add("service_line_id", request.ServiceLineId)
            .Add("billing_provider_id", request.BillingProviderId)
            .Add("unattributed", request.Unattributed)
            .Add("invoice_id", request.InvoiceId)
            .Add("sources", request.Sources)
            .Add("sort", request.Sort)
            .Add("sort_direction", request.SortDirection)
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
                    Path = "/api/patient-refunds/v1",
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
                var responseData = JsonUtils.Deserialize<PatientRefundsPage>(responseBody)!;
                return new WithRawResponse<PatientRefundsPage>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<PatientRefund>> GetAsyncCore(
        string patientRefundId,
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
                        "/api/patient-refunds/v1/{0}",
                        ValueConvert.ToPathParameterString(patientRefundId)
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
                var responseData = JsonUtils.Deserialize<PatientRefund>(responseBody)!;
                return new WithRawResponse<PatientRefund>()
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
        WithRawResponse<PatientRefund>
    > CreateAsyncCore(
        PatientRefundCreate request,
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
                    Path = "/api/patient-refunds/v1",
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
                var responseData = JsonUtils.Deserialize<PatientRefund>(responseBody)!;
                return new WithRawResponse<PatientRefund>()
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
        WithRawResponse<PatientRefund>
    > UpdateAsyncCore(
        string patientRefundId,
        PatientRefundUpdate request,
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
                        "/api/patient-refunds/v1/{0}",
                        ValueConvert.ToPathParameterString(patientRefundId)
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
                var responseData = JsonUtils.Deserialize<PatientRefund>(responseBody)!;
                return new WithRawResponse<PatientRefund>()
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
    /// Returns all patient refunds satisfying the search criteria AND whose organization_id matches
    /// the current organization_id of the authenticated user.
    /// </summary>
    /// <example><code>
    /// await client.PatientRefunds.V1.GetMultiAsync(new GetMultiPatientRefundsRequest());
    /// </code></example>
    public WithRawResponseTask<PatientRefundsPage> GetMultiAsync(
        GetMultiPatientRefundsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PatientRefundsPage>(
            GetMultiAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Retrieves a previously created patient refund by its `patient_refund_id`.
    /// </summary>
    /// <example><code>
    /// await client.PatientRefunds.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<PatientRefund> GetAsync(
        string patientRefundId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PatientRefund>(
            GetAsyncCore(patientRefundId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Creates a new patient refund record and returns the newly created PatientRefund object.
    /// The allocations can describe whether the refund is being applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    /// <example><code>
    /// await client.PatientRefunds.V1.CreateAsync(
    ///     new PatientRefundCreate
    ///     {
    ///         AmountCents = 1,
    ///         PatientExternalId = "patient_external_id",
    ///         Allocations = new List&lt;AllocationCreate&gt;()
    ///         {
    ///             new AllocationCreate
    ///             {
    ///                 AmountCents = 1,
    ///                 Target = new AllocationTargetCreate(
    ///                     new AllocationTargetCreate.ServiceLineById(
    ///                         "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    ///                     )
    ///                 ),
    ///             },
    ///             new AllocationCreate
    ///             {
    ///                 AmountCents = 1,
    ///                 Target = new AllocationTargetCreate(
    ///                     new AllocationTargetCreate.ServiceLineById(
    ///                         "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    ///                     )
    ///                 ),
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<PatientRefund> CreateAsync(
        PatientRefundCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PatientRefund>(
            CreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Updates the patient refund record matching the provided patient_refund_id.
    /// </summary>
    /// <example><code>
    /// await client.PatientRefunds.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new PatientRefundUpdate()
    /// );
    /// </code></example>
    public WithRawResponseTask<PatientRefund> UpdateAsync(
        string patientRefundId,
        PatientRefundUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PatientRefund>(
            UpdateAsyncCore(patientRefundId, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Deletes the patient refund record matching the provided patient_refund_id.
    /// </summary>
    /// <example><code>
    /// await client.PatientRefunds.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteAsync(
        string patientRefundId,
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
                        "/api/patient-refunds/v1/{0}",
                        ValueConvert.ToPathParameterString(patientRefundId)
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
