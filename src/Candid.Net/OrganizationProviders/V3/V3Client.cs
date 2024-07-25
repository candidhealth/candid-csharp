using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.OrganizationProviders.V3;

#nullable enable

namespace Candid.Net.OrganizationProviders.V3;

public class V3Client
{
    private RawClient _client;

    public V3Client(RawClient client)
    {
        _client = client;
    }

    public async Task<OrganizationProviderV2> GetAsync(Guid organizationProviderId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/api/organization-providers/v3/{organizationProviderId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<OrganizationProviderPageV2> GetMultiAsync(
        GetAllOrganizationProvidersRequestV2 request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.SearchTerm != null)
        {
            _query["search_term"] = request.SearchTerm;
        }
        if (request.Npi != null)
        {
            _query["npi"] = request.Npi;
        }
        if (request.IsRendering != null)
        {
            _query["is_rendering"] = request.IsRendering.ToString();
        }
        if (request.IsBilling != null)
        {
            _query["is_billing"] = request.IsBilling.ToString();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Sort != null)
        {
            _query["sort"] = JsonSerializer.Serialize(request.Sort.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/api/organization-providers/v3",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<OrganizationProviderPageV2>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<OrganizationProviderV2> CreateAsync(OrganizationProviderCreateV2 request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/api/organization-providers/v3",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<OrganizationProviderV2> UpdateAsync(
        Guid organizationProviderId,
        OrganizationProviderUpdateV2 request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/organization-providers/v3/{organizationProviderId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
