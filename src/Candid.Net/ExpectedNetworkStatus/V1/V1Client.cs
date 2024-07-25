using System.Net.Http;
using Candid.Net.Core;
using Candid.Net.ExpectedNetworkStatus.V1;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Computes the expected network status given the provided information.
    /// </summary>
    public async Task<ExpectedNetworkStatusResponse> ComputeAsync(
        ExpectedNetworkStatusRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/api/expected-network-status/v1",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ExpectedNetworkStatusResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
