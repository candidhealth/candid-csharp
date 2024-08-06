using System.Net.Http;
using System.Text.Json;
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
        string renderingProviderId,
        ExpectedNetworkStatusRequestV2 request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = $"/api/expected-network-status/v2/compute/{renderingProviderId}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ExpectedNetworkStatusResponseV2>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Computes all the in network providers for a given set of inputs.
    /// This endpoint is not available to all customers. Reach out to the Candid sales team
    /// to discuss enabling this endpoint if it is not available for your organization.
    /// </summary>
    public async Task<ComputeAllInNetworkProvidersResponse> ComputeAllInNetworkProvidersAsync(
        ComputeAllInNetworkProvidersRequest request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/expected-network-status/v2/compute",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ComputeAllInNetworkProvidersResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
