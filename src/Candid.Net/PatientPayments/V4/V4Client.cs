using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PatientPayments.V4;

public class V4Client
{
    private RawClient _client;

    public V4Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all patient payments satisfying the search criteria AND whose organization_id matches
    /// the current organization_id of the authenticated user.
    /// </summary>
    public async Task<PatientPaymentsPage> GetMultiAsync(
        GetMultiPatientPaymentsRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["sources"] = request.Sources.Select(_value => _value.ToString()).ToList();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.PatientExternalId != null)
        {
            _query["patient_external_id"] = request.PatientExternalId;
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
        if (request.Unattributed != null)
        {
            _query["unattributed"] = request.Unattributed.ToString();
        }
        if (request.InvoiceId != null)
        {
            _query["invoice_id"] = request.InvoiceId.ToString();
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
                Path = "/api/patient-payments/v4",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PatientPaymentsPage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Retrieves a previously created patient payment by its `patient_payment_id`.
    /// </summary>
    public async Task<PatientPayment> GetAsync(
        string patientPaymentId,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/patient-payments/v4/{patientPaymentId}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PatientPayment>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Creates a new patient payment record and returns the newly created PatientPayment object.
    /// The allocations can describe whether the payment is being applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    public async Task<PatientPayment> CreateAsync(
        PatientPaymentCreate request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/patient-payments/v4",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PatientPayment>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Updates the patient payment record matching the provided patient_payment_id.
    /// </summary>
    public async Task<PatientPayment> UpdateAsync(
        string patientPaymentId,
        PatientPaymentUpdate request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/patient-payments/v4/{patientPaymentId}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PatientPayment>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Deletes the patient payment record matching the provided patient_payment_id.
    /// </summary>
    public async Task DeleteAsync(string patientPaymentId, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/patient-payments/v4/{patientPaymentId}",
                Options = options
            }
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
