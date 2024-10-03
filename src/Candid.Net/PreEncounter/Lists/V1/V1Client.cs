using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Lists.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Gets patients with dependent objects for patients that match the query parameters.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Lists.V1.GetPatientListAsync(
    ///     new PatientListRequest
    ///     {
    ///         PageToken = "string",
    ///         Limit = 1,
    ///         SortField = "string",
    ///         SortDirection = Candid.Net.PreEncounter.SortDirection.Asc,
    ///         Filters = "string",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<PatientListPage> GetPatientListAsync(
        PatientListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.SortField != null)
        {
            _query["sort_field"] = request.SortField;
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        if (request.Filters != null)
        {
            _query["filters"] = request.Filters;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/lists/v1/patient",
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
                return JsonUtils.Deserialize<PatientListPage>(responseBody)!;
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
    /// Searches for appointments that match the query parameters.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Lists.V1.GetAppointmentListAsync(
    ///     new AppointmentsGetListRequest
    ///     {
    ///         SortField = "string",
    ///         SortDirection = Candid.Net.PreEncounter.SortDirection.Asc,
    ///         Limit = 1,
    ///         PageToken = "string",
    ///         Filters = "string",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<AppointmentListPage> GetAppointmentListAsync(
        AppointmentsGetListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.SortField != null)
        {
            _query["sort_field"] = request.SortField;
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Filters != null)
        {
            _query["filters"] = request.Filters;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/lists/v1/appointment",
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
                return JsonUtils.Deserialize<AppointmentListPage>(responseBody)!;
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
