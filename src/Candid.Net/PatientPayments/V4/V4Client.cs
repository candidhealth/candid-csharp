using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.PatientPayments.V4;

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
    public async Task<PatientPaymentsPage> GetMultiAsync(GetMultiPatientPaymentsRequest request)
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
                Method = HttpMethod.Get,
                Path = "/api/patient-payments/v4",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<PatientPaymentsPage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieves a previously created patient payment by its `patient_payment_id`.
    /// </summary>
    public async Task<PatientPayment> GetAsync(Guid patientPaymentId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/api/patient-payments/v4/{patientPaymentId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<PatientPayment>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a new patient payment record and returns the newly created PatientPayment object.
    /// The allocations can describe whether the payment is being applied toward a specific service line,
    /// claim, or billing provider.
    /// </summary>
    public async Task<PatientPayment> CreateAsync(PatientPaymentCreate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/api/patient-payments/v4",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<PatientPayment>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates the patient payment record matching the provided patient_payment_id.
    /// </summary>
    public async Task<PatientPayment> UpdateAsync(
        Guid patientPaymentId,
        PatientPaymentUpdate request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/patient-payments/v4/{patientPaymentId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<PatientPayment>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes the patient payment record matching the provided patient_payment_id.
    /// </summary>
    public async Task DeleteAsync(Guid patientPaymentId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/api/patient-payments/v4/{patientPaymentId}"
            }
        );
    }
}
