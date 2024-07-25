using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Coverages.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public class CoveragesClient
{
    private RawClient _client;

    public CoveragesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a new Coverage. A Coverage provides the high-level identifiers and descriptors of a specific insurance plan for a specific individual - typically the information you can find on an insurance card. Additionally a coverage will include detailed benefits information covered by the specific plan for the individual.
    /// </summary>
    public async Task<Coverage> CreateAsync(MutableCoverage request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/coverages/v1",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<Coverage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a Coverage. The path must contain the most recent version to prevent races. Updating historic versions is not supported.
    /// </summary>
    public async Task<Coverage> UpdateAsync(Guid id, int version, MutableCoverage request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/coverages/v1/{id}/{version}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<Coverage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// gets a specific Coverage
    /// </summary>
    public async Task<Coverage> GetAsync(Guid id)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = $"/coverages/v1/{id}" }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<Coverage>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Gets a coverage along with it's full history. The return list is ordered by version ascending.
    /// </summary>
    public async Task<IEnumerable<Coverage>> GetHistoryAsync(Guid id)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/coverages/v1/{id}/history"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<Coverage>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// returns a list of Coverages based on the search criteria
    /// </summary>
    public async Task<IEnumerable<Coverage>> GetMultiAsync(GetAllCoveragesRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.PatientId != null)
        {
            _query["patient_id"] = request.PatientId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/coverages/v1",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<Coverage>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Scans up to 100 coverage updates. The since query parameter is inclusive, and the result list is ordered by updatedAt descending.
    /// </summary>
    public async Task<IEnumerable<Coverage>> ScanAsync(CoverageScanRequest request)
    {
        var _query = new Dictionary<string, object>()
        {
            { "since", request.Since.ToString("o0") },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/coverages/v1/updates/scan",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<Coverage>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
