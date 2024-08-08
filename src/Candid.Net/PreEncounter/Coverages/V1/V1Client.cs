using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public class V1Client
{
    private RawClient _client;

    public V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a new Coverage. A Coverage provides the high-level identifiers and descriptors of a specific insurance plan for a specific individual - typically the information you can find on an insurance card. Additionally a coverage will include detailed benefits information covered by the specific plan for the individual.
    /// </summary>
    public async Task<Coverage> CreateAsync(MutableCoverage request, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/coverages/v1",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Coverage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Updates a Coverage. The path must contain the most recent version to prevent races. Updating historic versions is not supported.
    /// </summary>
    public async Task<Coverage> UpdateAsync(
        string id,
        string version,
        MutableCoverage request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Put,
                Path = $"/coverages/v1/{id}/{version}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Coverage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// gets a specific Coverage
    /// </summary>
    public async Task<Coverage> GetAsync(string id, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/coverages/v1/{id}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Coverage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Gets a coverage along with it's full history. The return list is ordered by version ascending.
    /// </summary>
    public async Task<IEnumerable<Coverage>> GetHistoryAsync(
        string id,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/coverages/v1/{id}/history",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Coverage>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// returns a list of Coverages based on the search criteria
    /// </summary>
    public async Task<IEnumerable<Coverage>> GetMultiAsync(
        GetAllCoveragesRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.PatientId != null)
        {
            _query["patient_id"] = request.PatientId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/coverages/v1",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Coverage>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }

    /// <summary>
    /// Scans up to 100 coverage updates. The since query parameter is inclusive, and the result list is ordered by updatedAt descending.
    /// </summary>
    public async Task<IEnumerable<Coverage>> ScanAsync(
        CoverageScanRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        _query["since"] = request.Since.ToString(Constants.DateTimeFormat);
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/coverages/v1/updates/scan",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Coverage>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidClientException("Failed to deserialize response", e);
            }
        }

        throw new CandidClientApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            JsonUtils.Deserialize<object>(responseBody)
        );
    }
}
