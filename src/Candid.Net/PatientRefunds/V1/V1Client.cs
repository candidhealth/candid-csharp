using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.PatientRefunds.V1;

#nullable enable

namespace Candid.Net.PatientRefunds.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all patient refunds satisfying the search criteria AND whose organization_id matches
    /// the current organization_id of the authenticated user.
    /// </summary>
    public async Task<PatientRefundsPage> GetMultiAsync(GetMultiPatientRefundsRequest request)
    {
        var _query = new Dictionary<string, object>() { };
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
        if (request.Sources != null)
        {
            _query["sources"] = JsonSerializer.Serialize(request.Sources.Value);
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
                Path = "/api/patient-refunds/v1",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<PatientRefundsPage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieves a previously created patient refund by its `patient_refund_id`.
    /// </summary>
    public async Task<PatientRefund> GetAsync(string patientRefundId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/patient-refunds/v1/{patientRefundId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<PatientRefund>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a new patient refund record and returns the newly created PatientRefund object.
    /// The allocations can describe whether the refund is being applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    public async Task<PatientRefund> CreateAsync(PatientRefundCreate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/patient-refunds/v1",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<PatientRefund>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates the patient refund record matching the provided patient_refund_id.
    /// </summary>
    public async Task<PatientRefund> UpdateAsync(
        string patientRefundId,
        PatientRefundUpdate request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/patient-refunds/v1/{patientRefundId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<PatientRefund>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes the patient refund record matching the provided patient_refund_id.
    /// </summary>
    public async Task DeleteAsync(string patientRefundId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/patient-refunds/v1/{patientRefundId}"
            }
        );
    }
}
