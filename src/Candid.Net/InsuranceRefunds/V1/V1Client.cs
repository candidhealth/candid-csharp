using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.InsuranceRefunds.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all insurance refunds satisfying the search criteria AND whose organization_id matches
    /// the current organization_id of the authenticated user.
    /// </summary>
    public async Task<InsuranceRefundsPage> GetMultiAsync(
        GetMultiInsuranceRefundsRequest request,
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
                Path = "/api/insurance-refunds/v1",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InsuranceRefundsPage>(responseBody)!;
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
    /// Retrieves a previously created insurance refund by its `insurance_refund_id`.
    /// If the refund does not exist, a `403` will be thrown.
    /// </summary>
    public async Task<InsuranceRefund> GetAsync(
        string insuranceRefundId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/insurance-refunds/v1/{insuranceRefundId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InsuranceRefund>(responseBody)!;
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
    /// Creates a new insurance refund record and returns the newly created `InsuranceRefund` object.
    /// The allocations can describe whether the refund is being applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    public async Task<InsuranceRefund> CreateAsync(
        InsuranceRefundCreate request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/insurance-refunds/v1",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InsuranceRefund>(responseBody)!;
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
    /// Updates the patient refund record matching the provided insurance_refund_id. If updating the refund amount,
    /// then the allocations must be appropriately updated as well.
    /// </summary>
    public async Task<InsuranceRefund> UpdateAsync(
        string insuranceRefundId,
        InsuranceRefundUpdate request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/insurance-refunds/v1/{insuranceRefundId}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<InsuranceRefund>(responseBody)!;
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
    /// Deletes the insurance refund record matching the provided `insurance_refund_id`.
    /// If the matching record's organization_id does not match the authenticated user's
    /// current organization_id, then a response code of `403` will be returned.
    /// </summary>
    public async Task DeleteAsync(string insuranceRefundId, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/insurance-refunds/v1/{insuranceRefundId}",
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
