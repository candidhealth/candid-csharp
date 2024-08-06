using System.Text.Json;
using Candid.Net;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net;

public class ServiceFacilityClient
{
    private RawClient _client;

    public ServiceFacilityClient(RawClient client)
    {
        _client = client;
    }

    public async Task<EncounterServiceFacility> UpdateAsync(
        string serviceFacilityId,
        EncounterServiceFacilityUpdate request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/service_facility/v2/{serviceFacilityId}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<EncounterServiceFacility>(responseBody)!;
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
