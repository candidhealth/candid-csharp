using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.Exports.V3;

#nullable enable

namespace Candid.Net.Exports.V3;

public class V3Client
{
    private RawClient _client;

    public V3Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieve CSV-formatted reports on claim submissions and outcomes. This endpoint returns Export objects that contain an
    /// authenticated URL to a customer's reports with a 2min TTL. The schema for the CSV export can be found [here](https://app.joincandidhealth.com/files/exports_schema.csv).
    ///
    /// **Schema changes:** Changing column order, removing columns, or changing the name of a column is considered a
    /// [Breaking Change](../../../api-principles/breaking-changes). Adding new columns to the end of the Exports file is not considered a
    /// Breaking Change and happens periodically. For this reason, it is important that any downstream automation or processes built on top
    /// of Candid Health's export files be resilient to the addition of new columns at the end of the file.
    ///
    /// **SLA guarantees:** Files for a given date are guaranteed to be available after 3 business days. For example, Friday's file will be
    /// available by Wednesday at the latest. If file generation is still in progress upon request before 3 business days have passed, the
    /// caller will receive a 422 response. If the file has already been generated, it will be served. Please email
    /// our [Support team](mailto:support@joincandidhealth.com) with any data requests outside of these stated guarantees.
    /// </summary>
    public async Task<GetExportsResponse> GetExportsAsync(
        GetExportsRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["start_date"] = request.StartDate.ToString();
        _query["end_date"] = request.EndDate.ToString();
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/exports/v3",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<GetExportsResponse>(responseBody)!;
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
}
