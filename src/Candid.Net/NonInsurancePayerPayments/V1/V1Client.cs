using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.NonInsurancePayerPayments.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all non-insurance payer payments
    /// </summary>
    /// <example><code>
    /// await client.NonInsurancePayerPayments.V1.GetMultiAsync(
    ///     new GetMultiNonInsurancePayerPaymentRequest()
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<NonInsurancePayerPaymentsPage> GetMultiAsync(
        GetMultiNonInsurancePayerPaymentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["check_number"] = request.CheckNumber;
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.NonInsurancePayerId != null)
        {
            _query["non_insurance_payer_id"] = request.NonInsurancePayerId;
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
                    Path = "/api/non-insurance-payer-payments/v1",
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
                return JsonUtils.Deserialize<NonInsurancePayerPaymentsPage>(responseBody)!;
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
    /// Retrieves a previously created non-insurance payer payment by its `non_insurance_payer_payment_id`.
    /// </summary>
    /// <example><code>
    /// await client.NonInsurancePayerPayments.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task<NonInsurancePayerPayment> GetAsync(
        string nonInsurancePayerPaymentId,
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
                        "/api/non-insurance-payer-payments/v1/{0}",
                        ValueConvert.ToPathParameterString(nonInsurancePayerPaymentId)
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
                return JsonUtils.Deserialize<NonInsurancePayerPayment>(responseBody)!;
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

    /// <example><code>
    /// await client.NonInsurancePayerPayments.V1.CreateAsync(
    ///     new NonInsurancePayerPaymentCreate
    ///     {
    ///         NonInsurancePayerId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         AmountCents = 1,
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
    public async System.Threading.Tasks.Task<NonInsurancePayerPayment> CreateAsync(
        NonInsurancePayerPaymentCreate request,
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
                    Path = "/api/non-insurance-payer-payments/v1",
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
                return JsonUtils.Deserialize<NonInsurancePayerPayment>(responseBody)!;
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

    /// <example><code>
    /// await client.NonInsurancePayerPayments.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new UpdateNonInsurancePayerPaymentRequest()
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<NonInsurancePayerPayment> UpdateAsync(
        string nonInsurancePayerPaymentId,
        UpdateNonInsurancePayerPaymentRequest request,
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
                        "/api/non-insurance-payer-payments/v1/{0}",
                        ValueConvert.ToPathParameterString(nonInsurancePayerPaymentId)
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
                return JsonUtils.Deserialize<NonInsurancePayerPayment>(responseBody)!;
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
    /// Deletes the non-insurance payer payment record matching the provided `non_insurance_payer_payment_id`.
    /// </summary>
    /// <example><code>
    /// await client.NonInsurancePayerPayments.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string nonInsurancePayerPaymentId,
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
                        "/api/non-insurance-payer-payments/v1/{0}",
                        ValueConvert.ToPathParameterString(nonInsurancePayerPaymentId)
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
