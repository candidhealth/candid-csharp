using System.Net.Http;
using Candid.Net.Core;
using Candid.Net.ExpectedNetworkStatus.V2;

#nullable enable

namespace Candid.Net.ExpectedNetworkStatus.V2;

public class V2Client
{
    private RawClient _client;

    public V2Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Computes the expected network status for a given rendering provider.
    /// This endpoint is not available to all customers. Reach out to the Candid sales team
    /// to discuss enabling this endpoint if it is not available for your organization.
    /// </summary>
    public async Task<ExpectedNetworkStatusResponseV2> ComputeForRenderingProviderAsync(
        Guid renderingProviderId,
        ExpectedNetworkStatusRequestV2 request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = $"/api/expected-network-status/v2/compute/{renderingProviderId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ExpectedNetworkStatusResponseV2>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Computes all the in network providers for a given set of inputs.
    /// This endpoint is not available to all customers. Reach out to the Candid sales team
    /// to discuss enabling this endpoint if it is not available for your organization.
    /// </summary>
    public async Task<ComputeAllInNetworkProvidersResponse> ComputeAllInNetworkProvidersAsync(
        ComputeAllInNetworkProvidersRequest request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/api/expected-network-status/v2/compute",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<ComputeAllInNetworkProvidersResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
