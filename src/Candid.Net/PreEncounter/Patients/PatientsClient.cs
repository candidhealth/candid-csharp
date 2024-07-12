using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;
using Candid.Net.PreEncounter;

#nullable enable

namespace Candid.Net.PreEncounter;

public class PatientsClient
{
    private RawClient _client;

    public PatientsClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Adds a patient. VersionConflictError is returned when the patient's external ID is already in use.
    /// </summary>
    public async Task<Patient> CreateAsync(MutablePatient request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Post,
                Path = "/patients",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<Patient>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Gets a patient.
    /// </summary>
    public async Task<Patient> GetAsync(string id)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest { Method = HttpMethod.Get, Path = $"/patients/{id}" }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<Patient>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Gets a patient along with it's full history. The return list is ordered by version ascending.
    /// </summary>
    public async Task<IEnumerable<Patient>> GetHistoryAsync(string id)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = $"/patients/{id}/history"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<Patient>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Updates a patient. The path must contain the most recent version to prevent races. Updating historic versions is not supported.
    /// </summary>
    public async Task<Patient> UpdateAsync(string id, int version, MutablePatient request)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Put,
                Path = $"/patients/{id}/{version}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<Patient>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Sets a patient as deactivated. The path must contain the most recent version to prevent races. Dactivating historic versions is not supported. Subsequent updates via PUT to the patient will "reactivate" the patient and set the deactivated flag to false.
    /// </summary>
    public async Task DeactivateAsync(string id, int version)
    {
        await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Delete,
                Path = $"/patients/{id}/{version}"
            }
        );
    }

    /// <summary>
    /// Searches for patients that match the query parameters.
    /// </summary>
    public async Task<IEnumerable<Patient>> SearchAsync(PatientsSearchRequest request)
    {
        var _query = new Dictionary<string, object>() { };
        if (request.NameContains != null)
        {
            _query["name-contains"] = request.NameContains;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/patients",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<Patient>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Scans up to 100 patient updates. The since query parameter is inclusive, and the result list is ordered by updatedAt descending.
    /// </summary>
    public async Task<IEnumerable<Patient>> ScanAsync(PatientScanRequest request)
    {
        var _query = new Dictionary<string, object>()
        {
            { "since", request.Since.ToString("o0") },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                Method = HttpMethod.Get,
                Path = "/patients/updates/scan",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonSerializer.Deserialize<IEnumerable<Patient>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
