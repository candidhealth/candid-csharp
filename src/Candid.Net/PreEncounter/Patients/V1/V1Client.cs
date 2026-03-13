using System.Text.Json;
using Candid.Net;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Common;

namespace Candid.Net.PreEncounter.Patients.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<WithRawResponse<Patient>> CreateAsyncCore(
        CreatePatientRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("skip_duplicate_check", request.SkipDuplicateCheck)
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
                    Method = HttpMethod.Post,
                    Path = "/patients/v1",
                    Body = request.Body,
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
                var responseData = JsonUtils.Deserialize<Patient>(responseBody)!;
                return new WithRawResponse<Patient>()
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
        WithRawResponse<Patient>
    > CreateWithMrnAsyncCore(
        CreatePatientWithMrnRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("skip_duplicate_check", request.SkipDuplicateCheck)
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
                    Method = HttpMethod.Post,
                    Path = "/patients/v1/with_mrn",
                    Body = request.Body,
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
                var responseData = JsonUtils.Deserialize<Patient>(responseBody)!;
                return new WithRawResponse<Patient>()
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
        WithRawResponse<PatientPage>
    > GetMultiAsyncCore(
        PatientsSearchRequestPaginated request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 5)
            .Add("limit", request.Limit)
            .Add("mrn", request.Mrn)
            .Add("page_token", request.PageToken)
            .Add("sort_field", request.SortField)
            .Add("sort_direction", request.SortDirection)
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
                    Path = "/patients/v1/get_multi",
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
                var responseData = JsonUtils.Deserialize<PatientPage>(responseBody)!;
                return new WithRawResponse<PatientPage>()
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
        WithRawResponse<IEnumerable<ExternalProvider>>
    > SearchProvidersAsyncCore(
        SearchProvidersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("search_criteria", request.SearchCriteria)
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
                    Path = "/patients/v1/search_providers",
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
                var responseData = JsonUtils.Deserialize<IEnumerable<ExternalProvider>>(
                    responseBody
                )!;
                return new WithRawResponse<IEnumerable<ExternalProvider>>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<Patient>> GetAsyncCore(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Path = string.Format(
                        "/patients/v1/{0}",
                        ValueConvert.ToPathParameterString(id)
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
                var responseData = JsonUtils.Deserialize<Patient>(responseBody)!;
                return new WithRawResponse<Patient>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<Patient>> GetByMrnAsyncCore(
        string mrn,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Path = string.Format(
                        "/patients/v1/mrn/{0}",
                        ValueConvert.ToPathParameterString(mrn)
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
                var responseData = JsonUtils.Deserialize<Patient>(responseBody)!;
                return new WithRawResponse<Patient>()
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
        WithRawResponse<IEnumerable<Patient>>
    > GetHistoryAsyncCore(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Path = string.Format(
                        "/patients/v1/{0}/history",
                        ValueConvert.ToPathParameterString(id)
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
                var responseData = JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
                return new WithRawResponse<IEnumerable<Patient>>()
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
        WithRawResponse<PatientCoverageSnapshot>
    > GetCoverageSnapshotAsyncCore(
        string id,
        GetCoverageSnapshotRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 1)
            .Add("date", request.Date)
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
                    Path = string.Format(
                        "/patients/v1/{0}/snapshot",
                        ValueConvert.ToPathParameterString(id)
                    ),
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
                var responseData = JsonUtils.Deserialize<PatientCoverageSnapshot>(responseBody)!;
                return new WithRawResponse<PatientCoverageSnapshot>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<Patient>> UpdateAsyncCore(
        string id,
        string version,
        MutablePatient request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "/patients/v1/{0}/{1}",
                        ValueConvert.ToPathParameterString(id),
                        ValueConvert.ToPathParameterString(version)
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
                var responseData = JsonUtils.Deserialize<Patient>(responseBody)!;
                return new WithRawResponse<Patient>()
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
        WithRawResponse<IEnumerable<Patient>>
    > SearchAsyncCore(
        PatientGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("mrn", request.Mrn)
            .Add("similar_name_ordering", request.SimilarNameOrdering)
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
                    Path = "/patients/v1",
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
                var responseData = JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
                return new WithRawResponse<IEnumerable<Patient>>()
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
        WithRawResponse<IEnumerable<Patient>>
    > ScanAsyncCore(
        PatientScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 2)
            .Add("since", request.Since)
            .Add("maxResults", request.MaxResults)
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
                    Path = "/patients/v1/updates/scan",
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
                var responseData = JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
                return new WithRawResponse<IEnumerable<Patient>>()
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
    /// Adds a patient.  VersionConflictError is returned when the patient's external ID is already in use.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.CreateAsync(
    ///     new CreatePatientRequest
    ///     {
    ///         Body = new MutablePatient
    ///         {
    ///             Name = new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///             OtherNames = new List&lt;HumanName&gt;()
    ///             {
    ///                 new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///             },
    ///             BirthDate = new DateOnly(2023, 1, 15),
    ///             BiologicalSex = Sex.Female,
    ///             PrimaryAddress = new global::Candid.Net.PreEncounter.Common.Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "line", "line" },
    ///                 City = "city",
    ///                 State = "state",
    ///                 PostalCode = "postal_code",
    ///                 Country = "country",
    ///             },
    ///             OtherAddresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///             {
    ///                 new global::Candid.Net.PreEncounter.Common.Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List&lt;string&gt;() { "line", "line" },
    ///                     City = "city",
    ///                     State = "state",
    ///                     PostalCode = "postal_code",
    ///                     Country = "country",
    ///                 },
    ///                 new global::Candid.Net.PreEncounter.Common.Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List&lt;string&gt;() { "line", "line" },
    ///                     City = "city",
    ///                     State = "state",
    ///                     PostalCode = "postal_code",
    ///                     Country = "country",
    ///                 },
    ///             },
    ///             OtherTelecoms = new List&lt;ContactPoint&gt;()
    ///             {
    ///                 new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///             },
    ///             Contacts = new List&lt;Contact&gt;()
    ///             {
    ///                 new Contact
    ///                 {
    ///                     Relationship = new List&lt;Relationship&gt;()
    ///                     {
    ///                         Relationship.Self,
    ///                         Relationship.Self,
    ///                     },
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                     Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                     {
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                     },
    ///                 },
    ///                 new Contact
    ///                 {
    ///                     Relationship = new List&lt;Relationship&gt;()
    ///                     {
    ///                         Relationship.Self,
    ///                         Relationship.Self,
    ///                     },
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                     Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                     {
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             GeneralPractitioners = new List&lt;ExternalProvider&gt;()
    ///             {
    ///                 new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                 },
    ///                 new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                 },
    ///             },
    ///             FilingOrder = new FilingOrder
    ///             {
    ///                 Coverages = new List&lt;string&gt;()
    ///                 {
    ///                     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 },
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<Patient> CreateAsync(
        CreatePatientRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Patient>(
            CreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Adds a patient and hydrates their MRN with a pre-existing MRN.  Once this patient is created their MRN will not be editable. BadRequestError is returned when the MRN is greater than 20 characters. VersionConflictError is returned when the patient's external ID is already in use.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.CreateWithMrnAsync(
    ///     new CreatePatientWithMrnRequest
    ///     {
    ///         Body = new MutablePatientWithMrn
    ///         {
    ///             Mrn = "mrn",
    ///             Name = new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///             OtherNames = new List&lt;HumanName&gt;()
    ///             {
    ///                 new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///             },
    ///             BirthDate = new DateOnly(2023, 1, 15),
    ///             BiologicalSex = Sex.Female,
    ///             PrimaryAddress = new global::Candid.Net.PreEncounter.Common.Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "line", "line" },
    ///                 City = "city",
    ///                 State = "state",
    ///                 PostalCode = "postal_code",
    ///                 Country = "country",
    ///             },
    ///             OtherAddresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///             {
    ///                 new global::Candid.Net.PreEncounter.Common.Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List&lt;string&gt;() { "line", "line" },
    ///                     City = "city",
    ///                     State = "state",
    ///                     PostalCode = "postal_code",
    ///                     Country = "country",
    ///                 },
    ///                 new global::Candid.Net.PreEncounter.Common.Address
    ///                 {
    ///                     Use = AddressUse.Home,
    ///                     Line = new List&lt;string&gt;() { "line", "line" },
    ///                     City = "city",
    ///                     State = "state",
    ///                     PostalCode = "postal_code",
    ///                     Country = "country",
    ///                 },
    ///             },
    ///             OtherTelecoms = new List&lt;ContactPoint&gt;()
    ///             {
    ///                 new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///             },
    ///             Contacts = new List&lt;Contact&gt;()
    ///             {
    ///                 new Contact
    ///                 {
    ///                     Relationship = new List&lt;Relationship&gt;()
    ///                     {
    ///                         Relationship.Self,
    ///                         Relationship.Self,
    ///                     },
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                     Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                     {
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                     },
    ///                 },
    ///                 new Contact
    ///                 {
    ///                     Relationship = new List&lt;Relationship&gt;()
    ///                     {
    ///                         Relationship.Self,
    ///                         Relationship.Self,
    ///                     },
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                     Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                     {
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                         new global::Candid.Net.PreEncounter.Common.Address
    ///                         {
    ///                             Use = AddressUse.Home,
    ///                             Line = new List&lt;string&gt;() { "line", "line" },
    ///                             City = "city",
    ///                             State = "state",
    ///                             PostalCode = "postal_code",
    ///                             Country = "country",
    ///                         },
    ///                     },
    ///                 },
    ///             },
    ///             GeneralPractitioners = new List&lt;ExternalProvider&gt;()
    ///             {
    ///                 new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                 },
    ///                 new ExternalProvider
    ///                 {
    ///                     Name = new HumanName
    ///                     {
    ///                         Family = "family",
    ///                         Given = new List&lt;string&gt;() { "given", "given" },
    ///                         Use = NameUse.Usual,
    ///                     },
    ///                     Telecoms = new List&lt;ContactPoint&gt;()
    ///                     {
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                         new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     },
    ///                 },
    ///             },
    ///             FilingOrder = new FilingOrder
    ///             {
    ///                 Coverages = new List&lt;string&gt;()
    ///                 {
    ///                     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 },
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<Patient> CreateWithMrnAsync(
        CreatePatientWithMrnRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Patient>(
            CreateWithMrnAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Searches for patients that match the query parameters.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.GetMultiAsync(new PatientsSearchRequestPaginated());
    /// </code></example>
    public WithRawResponseTask<PatientPage> GetMultiAsync(
        PatientsSearchRequestPaginated request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PatientPage>(
            GetMultiAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Searches for referring providers that match the query parameters.  The search is case-insensitive, supports fuzzy matching, and matches against provider name and NPI. The search criteria must be an alphanumeric string, and the search is limited to the first 20 results.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.SearchProvidersAsync(
    ///     new SearchProvidersRequest { SearchCriteria = "search_criteria" }
    /// );
    /// </code></example>
    public WithRawResponseTask<IEnumerable<ExternalProvider>> SearchProvidersAsync(
        SearchProvidersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<ExternalProvider>>(
            SearchProvidersAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Gets a patient.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.GetAsync("id");
    /// </code></example>
    public WithRawResponseTask<Patient> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Patient>(GetAsyncCore(id, options, cancellationToken));
    }

    /// <summary>
    /// Gets a patient by mrn.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.GetByMrnAsync("mrn");
    /// </code></example>
    public WithRawResponseTask<Patient> GetByMrnAsync(
        string mrn,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Patient>(GetByMrnAsyncCore(mrn, options, cancellationToken));
    }

    /// <summary>
    /// Gets a patient along with it's full history.  The return list is ordered by version ascending.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.GetHistoryAsync("id");
    /// </code></example>
    public WithRawResponseTask<IEnumerable<Patient>> GetHistoryAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<Patient>>(
            GetHistoryAsyncCore(id, options, cancellationToken)
        );
    }

    /// <summary>
    /// Gets a patient along with their coverages at a specific point in time. Note that the date passed in is only used to determine what the filing order was for that patient during that time. The actual data returned will always be the latest version of the patient and coverages.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.GetCoverageSnapshotAsync(
    ///     "id",
    ///     new GetCoverageSnapshotRequest()
    /// );
    /// </code></example>
    public WithRawResponseTask<PatientCoverageSnapshot> GetCoverageSnapshotAsync(
        string id,
        GetCoverageSnapshotRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<PatientCoverageSnapshot>(
            GetCoverageSnapshotAsyncCore(id, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Updates a patient. The path must contain the next version number to prevent race conditions. For example, if the current version of the patient is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the patient. Updating historic versions is not supported.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.UpdateAsync(
    ///     "id",
    ///     "version",
    ///     new MutablePatient
    ///     {
    ///         Name = new HumanName
    ///         {
    ///             Family = "family",
    ///             Given = new List&lt;string&gt;() { "given", "given" },
    ///             Use = NameUse.Usual,
    ///         },
    ///         OtherNames = new List&lt;HumanName&gt;()
    ///         {
    ///             new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///             new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///         },
    ///         BirthDate = new DateOnly(2023, 1, 15),
    ///         BiologicalSex = Sex.Female,
    ///         PrimaryAddress = new global::Candid.Net.PreEncounter.Common.Address
    ///         {
    ///             Use = AddressUse.Home,
    ///             Line = new List&lt;string&gt;() { "line", "line" },
    ///             City = "city",
    ///             State = "state",
    ///             PostalCode = "postal_code",
    ///             Country = "country",
    ///         },
    ///         OtherAddresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///         {
    ///             new global::Candid.Net.PreEncounter.Common.Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "line", "line" },
    ///                 City = "city",
    ///                 State = "state",
    ///                 PostalCode = "postal_code",
    ///                 Country = "country",
    ///             },
    ///             new global::Candid.Net.PreEncounter.Common.Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "line", "line" },
    ///                 City = "city",
    ///                 State = "state",
    ///                 PostalCode = "postal_code",
    ///                 Country = "country",
    ///             },
    ///         },
    ///         OtherTelecoms = new List&lt;ContactPoint&gt;()
    ///         {
    ///             new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///             new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///         },
    ///         Contacts = new List&lt;Contact&gt;()
    ///         {
    ///             new Contact
    ///             {
    ///                 Relationship = new List&lt;Relationship&gt;() { Relationship.Self, Relationship.Self },
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 Telecoms = new List&lt;ContactPoint&gt;()
    ///                 {
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 },
    ///                 Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                 {
    ///                     new global::Candid.Net.PreEncounter.Common.Address
    ///                     {
    ///                         Use = AddressUse.Home,
    ///                         Line = new List&lt;string&gt;() { "line", "line" },
    ///                         City = "city",
    ///                         State = "state",
    ///                         PostalCode = "postal_code",
    ///                         Country = "country",
    ///                     },
    ///                     new global::Candid.Net.PreEncounter.Common.Address
    ///                     {
    ///                         Use = AddressUse.Home,
    ///                         Line = new List&lt;string&gt;() { "line", "line" },
    ///                         City = "city",
    ///                         State = "state",
    ///                         PostalCode = "postal_code",
    ///                         Country = "country",
    ///                     },
    ///                 },
    ///             },
    ///             new Contact
    ///             {
    ///                 Relationship = new List&lt;Relationship&gt;() { Relationship.Self, Relationship.Self },
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 Telecoms = new List&lt;ContactPoint&gt;()
    ///                 {
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 },
    ///                 Addresses = new List&lt;global::Candid.Net.PreEncounter.Common.Address&gt;()
    ///                 {
    ///                     new global::Candid.Net.PreEncounter.Common.Address
    ///                     {
    ///                         Use = AddressUse.Home,
    ///                         Line = new List&lt;string&gt;() { "line", "line" },
    ///                         City = "city",
    ///                         State = "state",
    ///                         PostalCode = "postal_code",
    ///                         Country = "country",
    ///                     },
    ///                     new global::Candid.Net.PreEncounter.Common.Address
    ///                     {
    ///                         Use = AddressUse.Home,
    ///                         Line = new List&lt;string&gt;() { "line", "line" },
    ///                         City = "city",
    ///                         State = "state",
    ///                         PostalCode = "postal_code",
    ///                         Country = "country",
    ///                     },
    ///                 },
    ///             },
    ///         },
    ///         GeneralPractitioners = new List&lt;ExternalProvider&gt;()
    ///         {
    ///             new ExternalProvider
    ///             {
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 Telecoms = new List&lt;ContactPoint&gt;()
    ///                 {
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 },
    ///             },
    ///             new ExternalProvider
    ///             {
    ///                 Name = new HumanName
    ///                 {
    ///                     Family = "family",
    ///                     Given = new List&lt;string&gt;() { "given", "given" },
    ///                     Use = NameUse.Usual,
    ///                 },
    ///                 Telecoms = new List&lt;ContactPoint&gt;()
    ///                 {
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                     new ContactPoint { Value = "value", Use = ContactPointUse.Home },
    ///                 },
    ///             },
    ///         },
    ///         FilingOrder = new FilingOrder
    ///         {
    ///             Coverages = new List&lt;string&gt;()
    ///             {
    ///                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<Patient> UpdateAsync(
        string id,
        string version,
        MutablePatient request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Patient>(
            UpdateAsyncCore(id, version, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Sets a patient as deactivated.  The path must contain the most recent version plus 1 to prevent race conditions.  Deactivating historic versions is not supported.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.DeactivateAsync("id", "version");
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "/patients/v1/{0}/{1}",
                        ValueConvert.ToPathParameterString(id),
                        ValueConvert.ToPathParameterString(version)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
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
    /// Removes the deactivated flag for a patient.  The path must contain the most recent version plus 1 to prevent race conditions.  Reactivating historic versions is not supported.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.ReactivateAsync("id", "version");
    /// </code></example>
    public async global::System.Threading.Tasks.Task ReactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "/patients/v1/{0}/{1}",
                        ValueConvert.ToPathParameterString(id),
                        ValueConvert.ToPathParameterString(version)
                    ),
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
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
    /// Returns a list of Patients based on the search criteria.
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.SearchAsync(new PatientGetMultiRequest());
    /// </code></example>
    public WithRawResponseTask<IEnumerable<Patient>> SearchAsync(
        PatientGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<Patient>>(
            SearchAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Scans up to 1000 patient updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    ///
    /// **Polling Pattern:**
    /// To continuously poll for updates without gaps:
    /// 1. Make your initial request with a `since` timestamp (e.g., `since=2020-01-01T13:00:00.000Z`)
    /// 2. The API returns 100 by default and up to 1000 patient records, sorted by `updated_at` ascending
    /// 3. Find the `updated_at` value from the last record in the response
    /// 4. Use that `updated_at` value as the `since` parameter in your next request
    /// 5. Repeat steps 2-4 to ingest updates until you receive an empty list
    ///
    /// **Important Notes:**
    /// - The `since` parameter is inclusive, so you may receive the last record from the previous batch again (you can deduplicate by ID and version)
    /// - All patient records include `updated_at`, `id`, `version`, `deactivated`, and `updating_user` fields for tracking changes
    /// - Timestamps have millisecond resolution for precise ordering
    /// </summary>
    /// <example><code>
    /// await client.PreEncounter.Patients.V1.ScanAsync(
    ///     new PatientScanRequest { Since = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
    /// );
    /// </code></example>
    public WithRawResponseTask<IEnumerable<Patient>> ScanAsync(
        PatientScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<Patient>>(
            ScanAsyncCore(request, options, cancellationToken)
        );
    }
}
