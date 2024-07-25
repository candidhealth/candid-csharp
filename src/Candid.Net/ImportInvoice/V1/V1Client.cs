using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.ImportInvoice.V1;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Import an existing invoice from a third party service to reflect state in Candid.
    /// </summary>
    public async Task<ImportInvoice> ImportInvoiceAsync(CreateImportInvoiceRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/api/import-invoice/v1",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ImportInvoice>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Returns all Invoices for the authenticated user's organziation with all filters applied.
    /// </summary>
    public async Task<ImportInvoicesPage> GetMultiAsync(SearchImportedInvoicesRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.PatientExternalId != null)
        {
            _query["patient_external_id"] = request.PatientExternalId;
        }
        if (request.EncounterExternalId != null)
        {
            _query["encounter_external_id"] = request.EncounterExternalId;
        }
        if (request.Note != null)
        {
            _query["note"] = request.Note;
        }
        if (request.DueDateBefore != null)
        {
            _query["due_date_before"] = request.DueDateBefore.ToString();
        }
        if (request.DueDateAfter != null)
        {
            _query["due_date_after"] = request.DueDateAfter.ToString();
        }
        if (request.Status != null)
        {
            _query["status"] = JsonSerializer.Serialize(request.Status.Value);
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
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
                Path = "/api/import-invoice/v1",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ImportInvoicesPage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieve and view an import invoice
    /// </summary>
    public async Task<ImportInvoice> GetAsync(Guid invoiceId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/api/import-invoice/v1/{invoiceId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ImportInvoice>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update the information on the imported invoice
    /// </summary>
    public async Task<ImportInvoice> UpdateAsync(Guid invoiceId, ImportInvoiceUpdateRequest request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/import-invoice/v1/{invoiceId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ImportInvoice>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
