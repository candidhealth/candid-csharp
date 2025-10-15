using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.ExpectedNetworkStatus.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Computes the expected network status given the provided information.
    /// </summary>
    /// <example><code>
    /// await client.ExpectedNetworkStatus.V1.ComputeAsync(
    ///     new ExpectedNetworkStatusRequest
    ///     {
    ///         SubscriberPayerId = "subscriber_payer_id",
    ///         SubscriberPayerName = "subscriber_payer_name",
    ///         BillingProviderNpi = "billing_provider_npi",
    ///         BillingProviderTin = "billing_provider_tin",
    ///         RenderingProviderNpi = "rendering_provider_npi",
    ///         ContractedState = State.Aa,
    ///         DateOfService = "date_of_service",
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<ExpectedNetworkStatusResponse> ComputeAsync(
        ExpectedNetworkStatusRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/expected-network-status/v1",
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<ExpectedNetworkStatusResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
