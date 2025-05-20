using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ImportInvoice.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Import an existing invoice from a third party service to reflect state in Candid.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.ImportInvoice.V1.ImportInvoiceAsync(
    ///     new CreateImportInvoiceRequest
    ///     {
    ///         ExternalPaymentAccountConfigId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         PatientExternalId = "patient_external_id",
    ///         ExternalCustomerIdentifier = "external_customer_identifier",
    ///         Items = new List&lt;InvoiceItemCreate&gt;()
    ///         {
    ///             new InvoiceItemCreate
    ///             {
    ///                 Attribution = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 AmountCents = 1,
    ///             },
    ///             new InvoiceItemCreate
    ///             {
    ///                 Attribution = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 AmountCents = 1,
    ///             },
    ///         },
    ///         Status = Candid.Net.Invoices.V2.InvoiceStatus.Draft,
    ///         ExternalIdentifier = "external_identifier",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ImportInvoice> ImportInvoiceAsync(
        CreateImportInvoiceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/import-invoice/v1",
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
                return JsonUtils.Deserialize<ImportInvoice>(responseBody)!;
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
    /// Returns all Invoices for the authenticated user's organziation with all filters applied.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.ImportInvoice.V1.GetMultiAsync(new SearchImportedInvoicesRequest());
    /// </code>
    /// </example>
    public async Task<ImportInvoicesPage> GetMultiAsync(
        SearchImportedInvoicesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["status"] = request.Status.Select(_value => _value.Stringify()).ToList();
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
            _query["due_date_before"] = request.DueDateBefore.Value.ToString(Constants.DateFormat);
        }
        if (request.DueDateAfter != null)
        {
            _query["due_date_after"] = request.DueDateAfter.Value.ToString(Constants.DateFormat);
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
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
                Path = "/api/import-invoice/v1",
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
                return JsonUtils.Deserialize<ImportInvoicesPage>(responseBody)!;
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
    /// Retrieve and view an import invoice
    /// </summary>
    /// <example>
    /// <code>
    /// await client.ImportInvoice.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<ImportInvoice> GetAsync(
        string invoiceId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/import-invoice/v1/{invoiceId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ImportInvoice>(responseBody)!;
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
    /// Update the information on the imported invoice
    /// </summary>
    /// <example>
    /// <code>
    /// await client.ImportInvoice.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ImportInvoiceUpdateRequest()
    /// );
    /// </code>
    /// </example>
    public async Task<ImportInvoice> UpdateAsync(
        string invoiceId,
        ImportInvoiceUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/import-invoice/v1/{invoiceId}",
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
                return JsonUtils.Deserialize<ImportInvoice>(responseBody)!;
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
}
