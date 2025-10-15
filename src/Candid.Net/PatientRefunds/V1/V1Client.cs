using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.PatientRefunds.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all patient refunds satisfying the search criteria AND whose organization_id matches
    /// the current organization_id of the authenticated user.
    /// </summary>
    /// <example><code>
    /// await client.PatientRefunds.V1.GetMultiAsync(new GetMultiPatientRefundsRequest());
    /// </code></example>
    public async System.Threading.Tasks.Task<PatientRefundsPage> GetMultiAsync(
        GetMultiPatientRefundsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["sources"] = request.Sources.Select(_value => _value.Stringify()).ToList();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.PatientExternalId != null)
        {
            _query["patient_external_id"] = request.PatientExternalId;
        }
        if (request.ClaimId != null)
        {
            _query["claim_id"] = request.ClaimId;
        }
        if (request.ServiceLineId != null)
        {
            _query["service_line_id"] = request.ServiceLineId;
        }
        if (request.BillingProviderId != null)
        {
            _query["billing_provider_id"] = request.BillingProviderId;
        }
        if (request.Unattributed != null)
        {
            _query["unattributed"] = JsonUtils.Serialize(request.Unattributed.Value);
        }
        if (request.InvoiceId != null)
        {
            _query["invoice_id"] = request.InvoiceId;
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/patient-refunds/v1",
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
                return JsonUtils.Deserialize<PatientRefundsPage>(responseBody)!;
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
    /// Retrieves a previously created patient refund by its `patient_refund_id`.
    /// </summary>
    /// <example><code>
    /// await client.PatientRefunds.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task<PatientRefund> GetAsync(
        string patientRefundId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                return JsonUtils.Deserialize<PatientRefund>(responseBody)!;
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
    public async System.Threading.Tasks.Task<PatientRefund> CreateAsync(
        PatientRefundCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/patient-refunds/v1",
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
                return JsonUtils.Deserialize<PatientRefund>(responseBody)!;
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
    /// Updates the patient refund record matching the provided patient_refund_id.
    /// </summary>
    /// <example><code>
    /// await client.PatientRefunds.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new PatientRefundUpdate()
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<PatientRefund> UpdateAsync(
        string patientRefundId,
        PatientRefundUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                return JsonUtils.Deserialize<PatientRefund>(responseBody)!;
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
    /// Deletes the patient refund record matching the provided patient_refund_id.
    /// </summary>
    /// <example><code>
    /// await client.PatientRefunds.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string patientRefundId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
