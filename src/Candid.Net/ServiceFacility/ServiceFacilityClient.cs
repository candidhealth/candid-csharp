using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.ServiceFacility;

public partial class ServiceFacilityClient
{
    private RawClient _client;

    internal ServiceFacilityClient(RawClient client)
    {
        _client = client;
    }

    /// <example><code>
    /// await client.ServiceFacility.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new EncounterServiceFacilityUpdate()
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<EncounterServiceFacility> UpdateAsync(
        string serviceFacilityId,
        EncounterServiceFacilityUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "/api/service_facility/v2/{0}",
                        ValueConvert.ToPathParameterString(serviceFacilityId)
                    ),
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
                return JsonUtils.Deserialize<EncounterServiceFacility>(responseBody)!;
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
