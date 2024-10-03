using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

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
    /// <example>
    /// <code>
    /// await client.ExpectedNetworkStatus.V1.ComputeAsync(
    ///     new ExpectedNetworkStatusRequest
    ///     {
    ///         ExternalPatientId = "string",
    ///         SubscriberPayerId = "string",
    ///         SubscriberPayerName = "string",
    ///         SubscriberInsuranceType = Candid.Net.InsuranceTypeCode.C01,
    ///         SubscriberPlanName = "string",
    ///         BillingProviderNpi = "string",
    ///         BillingProviderTin = "string",
    ///         RenderingProviderNpi = "string",
    ///         ContractedState = State.Aa,
    ///         DateOfService = "string",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ExpectedNetworkStatusResponse> ComputeAsync(
        ExpectedNetworkStatusRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/expected-network-status/v1",
                Body = request,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ExpectedNetworkStatusResponse>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
