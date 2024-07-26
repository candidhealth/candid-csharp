using System.Net.Http;
using Candid.Net.Core;
using Candid.Net.CustomSchemas.V1;

#nullable enable

namespace Candid.Net.CustomSchemas.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all custom schemas.
    /// </summary>
    public async Task<SchemaGetMultiResponse> GetMultiAsync()
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/custom-schemas/v1"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<SchemaGetMultiResponse>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Return a custom schema with a given ID.
    /// </summary>
    public async Task<Schema> GetAsync(string schemaId)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/custom-schemas/v1/{schemaId}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Schema>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Create a custom schema. Schema keys can be referenced as inputs in user-configurable rules in the Rules
    /// Engine, and key-value pairs can be attached to claims via the Encounters API.
    /// </summary>
    public async Task<Schema> CreateAsync(SchemaCreate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/custom-schemas/v1",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Schema>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Update the name, description, or keys on a preexisting schema.
    /// </summary>
    public async Task<Schema> UpdateAsync(string schemaId, SchemaUpdate request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/custom-schemas/v1/{schemaId}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Schema>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
