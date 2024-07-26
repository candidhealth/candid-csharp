using System.Net.Http;
using Candid.Net.Core;
using Candid.Net.PreEncounter.Patients.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

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
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/patients/v1",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Patient>(responseBody)!;
        }
        throw new Exception(responseBody);
    }

    /// <summary>
    /// Gets a patient.
    /// </summary>
    public async Task<Patient> GetAsync(string id)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/patients/v1/{id}"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Patient>(responseBody)!;
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
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/patients/v1/{id}/history"
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
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
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Put,
                Path = $"/patients/v1/{id}/{version}",
                Body = request
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<Patient>(responseBody)!;
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
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Delete,
                Path = $"/patients/v1/{id}/{version}"
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
            _query["name_contains"] = request.NameContains;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/patients/v1",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
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
            { "since", request.Since.ToString(Constants.DateTimeFormat) },
        };
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/patients/v1/updates/scan",
                Query = _query
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
        }
        throw new Exception(responseBody);
    }
}
