using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

public partial class V2Client
{
    private RawClient _client;

    internal V2Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.OrganizationServiceFacilities.V2.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<OrganizationServiceFacility> GetAsync(
        string organizationServiceFacilityId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/organization-service-facilities/v2/{organizationServiceFacilityId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
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

    /// <example>
    /// <code>
    /// await client.OrganizationServiceFacilities.V2.GetMultiAsync(
    ///     new GetAllOrganizationServiceFacilitiesRequest
    ///     {
    ///         Limit = 100,
    ///         Name = "Test Service Facility",
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<OrganizationServiceFacilityPage> GetMultiAsync(
        GetAllOrganizationServiceFacilitiesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.Name != null)
        {
            _query["name"] = request.Name;
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
                Path = "/api/organization-service-facilities/v2",
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
                return JsonUtils.Deserialize<OrganizationServiceFacilityPage>(responseBody)!;
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

    /// <example>
    /// <code>
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
    /// </code>
    /// </example>
    public async Task<OrganizationServiceFacility> CreateAsync(
        OrganizationServiceFacilityCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/organization-service-facilities/v2",
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
                return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
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

    /// <example>
    /// <code>
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
    /// </code>
    /// </example>
    public async Task<OrganizationServiceFacility> UpdateAsync(
        string organizationServiceFacilityId,
        OrganizationServiceFacilityUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/organization-service-facilities/v2/{organizationServiceFacilityId}",
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
                return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
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

    /// <example>
    /// <code>
    /// await client.OrganizationServiceFacilities.V2.DeleteAsync("30F55EE6-8C0E-43FC-A7FC-DAC00D5BF569");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string organizationServiceFacilityId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/organization-service-facilities/v2/{organizationServiceFacilityId}",
                Options = options,
            },
            cancellationToken
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
