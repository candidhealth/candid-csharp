using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

public partial class V2Client : IV2Client
{
    private readonly RawClient _client;

    internal V2Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<OrganizationServiceFacility>
    > GetAsyncCore(
        string organizationServiceFacilityId,
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
                        "/api/organization-service-facilities/v2/{0}",
                        ValueConvert.ToPathParameterString(organizationServiceFacilityId)
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
                var responseData = JsonUtils.Deserialize<OrganizationServiceFacility>(
                    responseBody
                )!;
                return new WithRawResponse<OrganizationServiceFacility>()
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
        WithRawResponse<OrganizationServiceFacilityPage>
    > GetMultiAsyncCore(
        GetAllOrganizationServiceFacilitiesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 6)
            .Add("limit", request.Limit)
            .Add("name", request.Name)
            .Add("organization_service_facility_ids", request.OrganizationServiceFacilityIds)
            .Add("external_ids", request.ExternalIds)
            .Add("place_of_service_code", request.PlaceOfServiceCode)
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
                    Path = "/api/organization-service-facilities/v2",
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
                var responseData = JsonUtils.Deserialize<OrganizationServiceFacilityPage>(
                    responseBody
                )!;
                return new WithRawResponse<OrganizationServiceFacilityPage>()
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
        WithRawResponse<OrganizationServiceFacility>
    > GetByExternalIdAsyncCore(
        string externalId,
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
                        "/api/organization-service-facilities/v2/external-id/{0}",
                        ValueConvert.ToPathParameterString(externalId)
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
                var responseData = JsonUtils.Deserialize<OrganizationServiceFacility>(
                    responseBody
                )!;
                return new WithRawResponse<OrganizationServiceFacility>()
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
        WithRawResponse<OrganizationServiceFacility>
    > CreateAsyncCore(
        OrganizationServiceFacilityCreate request,
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
                    Path = "/api/organization-service-facilities/v2",
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
                var responseData = JsonUtils.Deserialize<OrganizationServiceFacility>(
                    responseBody
                )!;
                return new WithRawResponse<OrganizationServiceFacility>()
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
        WithRawResponse<OrganizationServiceFacility>
    > UpdateAsyncCore(
        string organizationServiceFacilityId,
        OrganizationServiceFacilityUpdate request,
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
                        "/api/organization-service-facilities/v2/{0}",
                        ValueConvert.ToPathParameterString(organizationServiceFacilityId)
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
                var responseData = JsonUtils.Deserialize<OrganizationServiceFacility>(
                    responseBody
                )!;
                return new WithRawResponse<OrganizationServiceFacility>()
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

    /// <example><code>
    /// await client.OrganizationServiceFacilities.V2.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<OrganizationServiceFacility> GetAsync(
        string organizationServiceFacilityId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OrganizationServiceFacility>(
            GetAsyncCore(organizationServiceFacilityId, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationServiceFacilities.V2.GetMultiAsync(
    ///     new GetAllOrganizationServiceFacilitiesRequest
    ///     {
    ///         Limit = 100,
    ///         Name = "Test Service Facility",
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<OrganizationServiceFacilityPage> GetMultiAsync(
        GetAllOrganizationServiceFacilitiesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OrganizationServiceFacilityPage>(
            GetMultiAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Looks up a single organization service facility by its `external_id` field. This can be useful
    /// for finding service facilities within Candid which are associated with service facilities in
    /// an external system.
    /// </summary>
    /// <example><code>
    /// await client.OrganizationServiceFacilities.V2.GetByExternalIdAsync("external_id");
    /// </code></example>
    public WithRawResponseTask<OrganizationServiceFacility> GetByExternalIdAsync(
        string externalId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OrganizationServiceFacility>(
            GetByExternalIdAsyncCore(externalId, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationServiceFacilities.V2.CreateAsync(
    ///     new OrganizationServiceFacilityCreate
    ///     {
    ///         Name = "Test Service Facility",
    ///         Aliases = new List&lt;string&gt;() { "Test Service Facility Alias" },
    ///         Description = "Test Service Facility Description",
    ///         Status = ServiceFacilityStatus.Active,
    ///         OperationalStatus = ServiceFacilityOperationalStatus.Closed,
    ///         Mode = ServiceFacilityMode.Instance,
    ///         Type = ServiceFacilityType.DiagnosticsOrTherapeuticsUnit,
    ///         PhysicalType = ServiceFacilityPhysicalType.Site,
    ///         Telecoms = new List&lt;string&gt;() { "555-555-5555" },
    ///         Address = new StreetAddressLongZip
    ///         {
    ///             Address1 = "123 Main St",
    ///             Address2 = "Apt 1",
    ///             City = "New York",
    ///             State = State.Ny,
    ///             ZipCode = "10001",
    ///             ZipPlusFourCode = "1234",
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<OrganizationServiceFacility> CreateAsync(
        OrganizationServiceFacilityCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OrganizationServiceFacility>(
            CreateAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationServiceFacilities.V2.UpdateAsync(
    ///     "30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569",
    ///     new OrganizationServiceFacilityUpdate
    ///     {
    ///         Name = "Test Service Facility",
    ///         Aliases = new List&lt;string&gt;() { "Test Service Facility Alias" },
    ///         Description = "Test Service Facility Description",
    ///         Status = ServiceFacilityStatus.Active,
    ///         OperationalStatus = ServiceFacilityOperationalStatus.Closed,
    ///         Mode = ServiceFacilityMode.Instance,
    ///         Type = ServiceFacilityType.DiagnosticsOrTherapeuticsUnit,
    ///         PhysicalType = ServiceFacilityPhysicalType.Site,
    ///         Telecoms = new List&lt;string&gt;() { "555-555-5555" },
    ///         Address = new StreetAddressLongZip
    ///         {
    ///             Address1 = "123 Main St",
    ///             Address2 = "Apt 1",
    ///             City = "New York",
    ///             State = State.Ny,
    ///             ZipCode = "10001",
    ///             ZipPlusFourCode = "1234",
    ///         },
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<OrganizationServiceFacility> UpdateAsync(
        string organizationServiceFacilityId,
        OrganizationServiceFacilityUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<OrganizationServiceFacility>(
            UpdateAsyncCore(organizationServiceFacilityId, request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.OrganizationServiceFacilities.V2.DeleteAsync("30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569");
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteAsync(
        string organizationServiceFacilityId,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "/api/organization-service-facilities/v2/{0}",
                        ValueConvert.ToPathParameterString(organizationServiceFacilityId)
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
}
