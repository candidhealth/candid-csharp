using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.OrganizationServiceFacilities.V2;

public partial class V2Client
{
    private RawClient _client;

    internal V2Client(RawClient client)
    {
        _client = client;
    }

    /// <example><code>
    /// await client.OrganizationServiceFacilities.V2.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task<OrganizationServiceFacility> GetAsync(
        string organizationServiceFacilityId,
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
                        "/api/organization-service-facilities/v2/{0}",
                        ValueConvert.ToPathParameterString(organizationServiceFacilityId)
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
                return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
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
    public async System.Threading.Tasks.Task<OrganizationServiceFacilityPage> GetMultiAsync(
        GetAllOrganizationServiceFacilitiesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["organization_service_facility_ids"] = request.OrganizationServiceFacilityIds;
        _query["external_ids"] = request.ExternalIds;
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.Name != null)
        {
            _query["name"] = request.Name;
        }
        if (request.PlaceOfServiceCode != null)
        {
            _query["place_of_service_code"] = request.PlaceOfServiceCode.Value.Stringify();
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
                    Path = "/api/organization-service-facilities/v2",
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
                return JsonUtils.Deserialize<OrganizationServiceFacilityPage>(responseBody)!;
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
    /// Looks up a single organization service facility by its `external_id` field. This can be useful
    /// for finding service facilities within Candid which are associated with service facilities in
    /// an external system.
    /// </summary>
    /// <example><code>
    /// await client.OrganizationServiceFacilities.V2.GetByExternalIdAsync("external_id");
    /// </code></example>
    public async System.Threading.Tasks.Task<OrganizationServiceFacility> GetByExternalIdAsync(
        string externalId,
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
                        "/api/organization-service-facilities/v2/external-id/{0}",
                        ValueConvert.ToPathParameterString(externalId)
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
                return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
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
    public async System.Threading.Tasks.Task<OrganizationServiceFacility> CreateAsync(
        OrganizationServiceFacilityCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/organization-service-facilities/v2",
                    Body = request,
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
                return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
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
    public async System.Threading.Tasks.Task<OrganizationServiceFacility> UpdateAsync(
        string organizationServiceFacilityId,
        OrganizationServiceFacilityUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
                return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
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

    /// <example><code>
    /// await client.OrganizationServiceFacilities.V2.DeleteAsync("30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569");
    /// </code></example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string organizationServiceFacilityId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
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
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
