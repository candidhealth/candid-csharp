using System.Net.Http;
using System.Text.Json;
using Candid.Net.Contracts.V2;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Contracts.V2;

public class V2Client
{
    private RawClient _client;

    public V2Client(RawClient client)
    {
        _client = client;
    }

    public async Task<ContractWithProviders> GetAsync(string contractId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/contracts/v2/{contractId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ContractWithProviders>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<ContractsPage> GetMultiAsync(GetMultiContractsRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.ContractingProviderId != null)
        {
            _query["contracting_provider_id"] = request.ContractingProviderId.ToString();
        }
        if (request.RenderingProviderIds != null)
        {
            _query["rendering_provider_ids"] = request.RenderingProviderIds.ToString();
        }
        if (request.PayerNames != null)
        {
            _query["payer_names"] = request.PayerNames;
        }
        if (request.States != null)
        {
            _query["states"] = JsonSerializer.Serialize(request.States.Value);
        }
        if (request.ContractStatus != null)
        {
            _query["contract_status"] = JsonSerializer.Serialize(request.ContractStatus.Value);
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/contracts/v2",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ContractsPage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a new contract within the user's current organization
    /// </summary>
    public async Task<ContractWithProviders> CreateAsync(ContractCreate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/contracts/v2",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ContractWithProviders>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task DeleteAsync(string contractId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/contracts/v2/{contractId}"
            }
        );
    }

    public async Task<ContractWithProviders> UpdateAsync(string contractId, ContractUpdate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/contracts/v2/{contractId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ContractWithProviders>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
