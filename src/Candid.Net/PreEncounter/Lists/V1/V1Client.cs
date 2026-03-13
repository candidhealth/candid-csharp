using System.Text.Json;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.PreEncounter.Lists.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<PatientListPage>
    > GetPatientListAsyncCore(
        PatientListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 7)
            .Add("page_token", request.PageToken)
            .Add("limit", request.Limit)
            .Add("sort_field", request.SortField)
            .Add("sort_direction", request.SortDirection)
            .Add("filters", request.Filters)
            .Add("include_deactivated", request.IncludeDeactivated)
            .Add("redirect_to_primary", request.RedirectToPrimary)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/lists/v1/patient",
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
                var responseData = JsonUtils.Deserialize<PatientListPage>(responseBody)!;
                return new WithRawResponse<PatientListPage>()
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
        WithRawResponse<AppointmentListPage>
    > GetAppointmentListAsyncCore(
        AppointmentsGetListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 7)
            .Add("sort_field", request.SortField)
            .Add("sort_direction", request.SortDirection)
            .Add("limit", request.Limit)
            .Add("page_token", request.PageToken)
            .Add("filters", request.Filters)
            .Add("include_deactivated", request.IncludeDeactivated)
            .Add("include_merged_patient_data", request.IncludeMergedPatientData)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.PreEncounter,
                    Method = HttpMethod.Get,
                    Path = "/lists/v1/appointment",
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
                var responseData = JsonUtils.Deserialize<AppointmentListPage>(responseBody)!;
                return new WithRawResponse<AppointmentListPage>()
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
    /// Gets patients with dependent objects for patients that match the query parameters.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Lists.V1.GetPatientListAsync(new PatientListRequest());
    /// </code></example>
    public WithRawResponseTask<PatientListPage> GetPatientListAsync(
        PatientListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PatientListPage>(
            GetPatientListAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Searches for appointments that match the query parameters.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Lists.V1.GetAppointmentListAsync(new AppointmentsGetListRequest());
    /// </code></example>
    public WithRawResponseTask<AppointmentListPage> GetAppointmentListAsync(
        AppointmentsGetListRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<AppointmentListPage>(
            GetAppointmentListAsyncCore(request, options, cancellationToken)
        );
    }
}
