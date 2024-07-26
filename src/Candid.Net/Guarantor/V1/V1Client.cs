using System.Net.Http;
using Candid.Net.Core;
using Candid.Net.Guarantor.V1;

#nullable enable

namespace Candid.Net.Guarantor.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a new guarantor and returns the newly created Guarantor object.
    /// </summary>
    public async Task<Guarantor> CreateAsync(string encounterId, GuarantorCreate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = $"/api/guarantors/v1/{encounterId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Guarantor>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Retrieves a guarantor by its `guarantor_id`.
    /// </summary>
    public async Task<Guarantor> GetAsync(string guarantorId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/guarantors/v1/{guarantorId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Guarantor>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a guarantor by its `guarantor_id`.
    /// </summary>
    public async Task<Guarantor> UpdateAsync(string guarantorId, GuarantorUpdate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/guarantors/v1/{guarantorId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Guarantor>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
