using System.Net.Http;
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

    public async Task<OrganizationServiceFacility> GetAsync(string organizationServiceFacilityId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/organization-service-facilities/v2/{organizationServiceFacilityId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
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
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/organization-service-facilities/v2",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<OrganizationServiceFacilityPage>(responseBody)!;
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
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/organization-service-facilities/v2",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<OrganizationServiceFacility> UpdateAsync(
        string organizationServiceFacilityId,
        OrganizationServiceFacilityUpdate request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/organization-service-facilities/v2/{organizationServiceFacilityId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<OrganizationServiceFacility>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task DeleteAsync(string organizationServiceFacilityId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/organization-service-facilities/v2/{organizationServiceFacilityId}"
            }
        );
    }
}
