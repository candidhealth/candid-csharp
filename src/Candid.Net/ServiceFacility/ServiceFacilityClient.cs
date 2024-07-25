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
        Guid serviceFacilityId,
        EncounterServiceFacilityUpdate request
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/service_facility/v2/{serviceFacilityId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<EncounterServiceFacility>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
