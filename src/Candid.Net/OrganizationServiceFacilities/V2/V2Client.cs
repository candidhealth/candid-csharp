using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.OrganizationServiceFacilities.V2;

#nullable enable

namespace Candid.Net.OrganizationServiceFacilities.V2;

public class V2Client
{
    private RawClient _client;

    public V2Client(RawClient client)
    {
        _client = client;
    }

    public async Task<OrganizationServiceFacility> GetAsync(Guid organizationServiceFacilityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/api/organization-service-facilities/v2/{organizationServiceFacilityId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<OrganizationServiceFacility>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<OrganizationServiceFacilityPage> GetMultiAsync(
        GetAllOrganizationServiceFacilitiesRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
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
                Method = HttpMethod.Get,
                Path = "/api/organization-service-facilities/v2",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<OrganizationServiceFacilityPage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<OrganizationServiceFacility> CreateAsync(
        OrganizationServiceFacilityCreate request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/api/organization-service-facilities/v2",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<OrganizationServiceFacility>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<OrganizationServiceFacility> UpdateAsync(
        Guid organizationServiceFacilityId,
        OrganizationServiceFacilityUpdate request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/organization-service-facilities/v2/{organizationServiceFacilityId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<OrganizationServiceFacility>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task DeleteAsync(Guid organizationServiceFacilityId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/api/organization-service-facilities/v2/{organizationServiceFacilityId}"
            }
        );
    }
}
