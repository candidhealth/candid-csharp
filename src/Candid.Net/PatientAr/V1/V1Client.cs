using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.PatientAr.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// NOTE: This service is in-development and can only be used by select partners. Please contact Candid Health to request access.
    ///
    /// Retrieve a list of inventory records based on the provided filters. Each inventory record provides the latest invoiceable status of the associated claim.
    /// The response is paginated, and the `page_token` can be used to retrieve subsequent pages. Initial requests should not include `page_token`.
    /// </summary>
    /// <example><code>
    /// await client.PatientAr.V1.ListInventoryAsync(new GetInventoryRecordsRequest());
    /// </code></example>
    public async System.Threading.Tasks.Task<ListInventoryPagedResponse> ListInventoryAsync(
        GetInventoryRecordsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Since != null)
        {
            _query["since"] = request.Since.Value.ToString(Constants.DateTimeFormat);
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
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
                    Path = "/api/patient-ar/v1/inventory",
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
                return JsonUtils.Deserialize<ListInventoryPagedResponse>(responseBody)!;
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
    /// NOTE: This service is in-development and can only be used by select partners. Please contact Candid Health to request access.
    ///
    /// Provides detailed itemization of invoice data for a specific claim.
    /// </summary>
    /// <example><code>
    /// await client.PatientAr.V1.ItemizeAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task<InvoiceItemizationResponse> ItemizeAsync(
        string claimId,
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
                        "/api/patient-ar/v1/invoice-itemization/{0}",
                        ValueConvert.ToPathParameterString(claimId)
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
                return JsonUtils.Deserialize<InvoiceItemizationResponse>(responseBody)!;
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
}
