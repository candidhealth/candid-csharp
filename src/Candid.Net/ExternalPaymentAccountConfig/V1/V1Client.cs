using System.Net.Http;
using Candid.Net.Core;
using Candid.Net.ExternalPaymentAccountConfig.V1;

#nullable enable

namespace Candid.Net.ExternalPaymentAccountConfig.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    public async Task<ExternalPaymentAccountConfigPage> GetMultiAsync(
        GetExternalPaymentAccountConfigsRequest request
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
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
                Path = "/api/external-payment-account-config/v1",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ExternalPaymentAccountConfigPage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
