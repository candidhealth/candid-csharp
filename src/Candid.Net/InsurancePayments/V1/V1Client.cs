using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all non-ERA originated insurance payments satisfying the search criteria
    /// </summary>
    /// <example>
    /// <code>
    /// await client.InsurancePayments.V1.GetMultiAsync(
    ///     new GetMultiInsurancePaymentRequest
    ///     {
    ///         Limit = 1,
    ///         PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         ClaimId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         ServiceLineId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         BillingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         Sort = InsurancePaymentSortField.AmountCents,
    ///         SortDirection = Candid.Net.SortDirection.Asc,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<InsurancePaymentsPage> GetMultiAsync(
        GetMultiInsurancePaymentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.PayerUuid != null)
        {
            _query["payer_uuid"] = request.PayerUuid.ToString();
        }
        if (request.ClaimId != null)
        {
            _query["claim_id"] = request.ClaimId.ToString();
        }
        if (request.ServiceLineId != null)
        {
            _query["service_line_id"] = request.ServiceLineId.ToString();
        }
        if (request.BillingProviderId != null)
        {
            _query["billing_provider_id"] = request.BillingProviderId.ToString();
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
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/insurance-payments/v1",
                Query = _query,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InsurancePaymentsPage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Retrieves a previously created insurance payment by its `insurance_payment_id`.
    /// If the payment does not exist, a `403` will be thrown.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.InsurancePayments.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<InsurancePayment> GetAsync(
        string insurancePaymentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/insurance-payments/v1/{insurancePaymentId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InsurancePayment>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Creates a new insurance payment record and returns the newly created `InsurancePayment` object. This endpoint
    /// should only be used for insurance payments that do not have a corresponding ERA (for example: a settlement check
    /// from a payer). If the payment is an ERA, then you should used the insurance-adjudications API.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.InsurancePayments.V1.CreateAsync(
    ///     new InsurancePaymentCreate
    ///     {
    ///         PayerIdentifier = new PayerInfo(),
    ///         AmountCents = 1,
    ///         PaymentTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         PaymentNote = "string",
    ///         Allocations = new List<AllocationCreate>()
    ///         {
    ///             new AllocationCreate
    ///             {
    ///                 AmountCents = 1,
    ///                 Target = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<InsurancePayment> CreateAsync(
        InsurancePaymentCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/insurance-payments/v1",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InsurancePayment>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Updates the patient payment record matching the provided insurance_payment_id. If updating the payment amount,
    /// then the allocations must be appropriately updated as well.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.InsurancePayments.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new InsurancePaymentUpdate
    ///     {
    ///         PaymentTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         PaymentNote = "string",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<InsurancePayment> UpdateAsync(
        string insurancePaymentId,
        InsurancePaymentUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/insurance-payments/v1/{insurancePaymentId}",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InsurancePayment>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Deletes the insurance payment record matching the provided `insurance_payment_id`.
    /// If the matching record's organization_id does not match the authenticated user's
    /// current organization_id, then a response code of `403` will be returned.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.InsurancePayments.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string insurancePaymentId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/insurance-payments/v1/{insurancePaymentId}",
                Options = options,
            },
            cancellationToken
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
