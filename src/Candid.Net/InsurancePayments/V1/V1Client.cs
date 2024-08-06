using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.InsurancePayments.V1;

#nullable enable

namespace Candid.Net.InsurancePayments.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all non-ERA originated insurance payments satisfying the search criteria
    /// </summary>
    public async Task<InsurancePaymentsPage> GetMultiAsync(
        GetMultiInsurancePaymentRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
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
            _query["sort"] = JsonSerializer.Serialize(request.Sort.Value);
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = JsonSerializer.Serialize(request.SortDirection.Value);
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
                Options = options
            }
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
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Retrieves a previously created insurance payment by its `insurance_payment_id`.
    /// If the payment does not exist, a `403` will be thrown.
    /// </summary>
    public async Task<InsurancePayment> GetAsync(
        string insurancePaymentId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/insurance-payments/v1/{insurancePaymentId}",
                Options = options
            }
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
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Creates a new insurance payment record and returns the newly created `InsurancePayment` object. This endpoint
    /// should only be used for insurance payments that do not have a corresponding ERA (for example: a settlement check
    /// from a payer). If the payment is an ERA, then you should used the insurance-adjudications API.
    /// </summary>
    public async Task<InsurancePayment> CreateAsync(
        InsurancePaymentCreate request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/insurance-payments/v1",
                Body = request,
                Options = options
            }
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
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Updates the patient payment record matching the provided insurance_payment_id. If updating the payment amount,
    /// then the allocations must be appropriately updated as well.
    /// </summary>
    public async Task<InsurancePayment> UpdateAsync(
        string insurancePaymentId,
        InsurancePaymentUpdate request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/insurance-payments/v1/{insurancePaymentId}",
                Body = request,
                Options = options
            }
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
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Deletes the insurance payment record matching the provided `insurance_payment_id`.
    /// If the matching record's organization_id does not match the authenticated user's
    /// current organization_id, then a response code of `403` will be returned.
    /// </summary>
    public async Task DeleteAsync(string insurancePaymentId, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/insurance-payments/v1/{insurancePaymentId}",
                Options = options
            }
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
