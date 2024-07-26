using System.Net.Http;
using Candid.Net.Core;
using Candid.Net.InsuranceAdjudications.V1;

#nullable enable

namespace Candid.Net.InsuranceAdjudications.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Retrieves a previously created insurance adjudication by its `insurance_adjudication_id`.
    /// </summary>
    public async Task<InsuranceAdjudication> GetAsync(string insuranceAdjudicationId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/insurance-adjudications/v1/{insuranceAdjudicationId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<InsuranceAdjudication>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Creates a new insurance adjudication record and returns the newly created InsuranceAdjudication object.
    /// </summary>
    public async Task<InsuranceAdjudication> CreateAsync(InsuranceAdjudicationCreate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/insurance-adjudications/v1",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<InsuranceAdjudication>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Deletes the insurance adjudication record matching the provided insurance_adjudication_id.
    /// </summary>
    public async Task DeleteAsync(string insuranceAdjudicationId)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/insurance-adjudications/v1/{insuranceAdjudicationId}"
            }
        );
    }
}
