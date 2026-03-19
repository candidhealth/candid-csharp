using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.ImportInvoice.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<ImportInvoice>
    > ImportInvoiceAsyncCore(
        CreateImportInvoiceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/import-invoice/v1",
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ImportInvoice>(responseBody)!;
                return new WithRawResponse<ImportInvoice>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<ImportInvoicesPage>
    > GetMultiAsyncCore(
        SearchImportedInvoicesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 10)
            .Add("patient_external_id", request.PatientExternalId)
            .Add("encounter_external_id", request.EncounterExternalId)
            .Add("note", request.Note)
            .Add("due_date_before", request.DueDateBefore)
            .Add("due_date_after", request.DueDateAfter)
            .Add("status", request.Status)
            .Add("limit", request.Limit)
            .Add("sort", request.Sort)
            .Add("sort_direction", request.SortDirection)
            .Add("page_token", request.PageToken)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/import-invoice/v1",
                    QueryString = _queryString,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ImportInvoicesPage>(responseBody)!;
                return new WithRawResponse<ImportInvoicesPage>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<WithRawResponse<ImportInvoice>> GetAsyncCore(
        string invoiceId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/api/import-invoice/v1/{0}",
                        ValueConvert.ToPathParameterString(invoiceId)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ImportInvoice>(responseBody)!;
                return new WithRawResponse<ImportInvoice>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<ImportInvoice>
    > UpdateAsyncCore(
        string invoiceId,
        ImportInvoiceUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "/api/import-invoice/v1/{0}",
                        ValueConvert.ToPathParameterString(invoiceId)
                    ),
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<ImportInvoice>(responseBody)!;
                return new WithRawResponse<ImportInvoice>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Import an existing invoice from a third party service to reflect state in Candid.
    /// </summary>
    /// <example><code>
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
    ///                 Attribution = new InvoiceItemAttributionCreate(
    ///                     new InvoiceItemAttributionCreate.ServiceLineId(
    ///                         "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    ///                     )
    ///                 ),
    ///                 AmountCents = 1,
    ///             },
    ///             new InvoiceItemCreate
    ///             {
    ///                 Attribution = new InvoiceItemAttributionCreate(
    ///                     new InvoiceItemAttributionCreate.ServiceLineId(
    ///                         "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    ///                     )
    ///                 ),
    ///                 AmountCents = 1,
    ///             },
    ///         },
    ///         Status = global::Candid.Net.Invoices.V2.InvoiceStatus.Draft,
    ///         ExternalIdentifier = "external_identifier",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<ImportInvoice> ImportInvoiceAsync(
        CreateImportInvoiceRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ImportInvoice>(
            ImportInvoiceAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Returns all Invoices for the authenticated user's organziation with all filters applied.
    /// </summary>
    /// <example><code>
    /// await client.ImportInvoice.V1.GetMultiAsync(new SearchImportedInvoicesRequest());
    /// </code></example>
    public WithRawResponseTask<ImportInvoicesPage> GetMultiAsync(
        SearchImportedInvoicesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ImportInvoicesPage>(
            GetMultiAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Retrieve and view an import invoice
    /// </summary>
    /// <example><code>
    /// await client.ImportInvoice.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<ImportInvoice> GetAsync(
        string invoiceId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ImportInvoice>(
            GetAsyncCore(invoiceId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Update the information on the imported invoice
    /// </summary>
    /// <example><code>
    /// await client.ImportInvoice.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ImportInvoiceUpdateRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<ImportInvoice> UpdateAsync(
        string invoiceId,
        ImportInvoiceUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ImportInvoice>(
            UpdateAsyncCore(invoiceId, request, options, cancellationToken)
        );
    }
}
