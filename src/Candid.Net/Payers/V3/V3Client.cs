using System.Net.Http;
using Candid.Net.Core;
using Candid.Net.Payers.V3;

#nullable enable

namespace Candid.Net.Payers.V3;

public class V3Client
{
    private RawClient _client;

    public V3Client(RawClient client)
    {
        _client = client;
    }

    public async Task<Payer> GetAsync(string payerUuid)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/payers/v3/{payerUuid}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Payer>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    public async Task<PayerPage> GetAllAsync(GetAllPayersRequest request)
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
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/payers/v3",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<PayerPage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
