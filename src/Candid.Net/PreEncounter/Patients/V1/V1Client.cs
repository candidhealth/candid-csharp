using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Patients.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Adds a patient. VersionConflictError is returned when the patient's external ID is already in use.
    /// </summary>
    public async Task<Patient> CreateAsync(MutablePatient request, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/patients/v1",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Patient>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Gets a patient.
    /// </summary>
    public async Task<Patient> GetAsync(string id, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/patients/v1/{id}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Patient>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Gets a patient along with it's full history. The return list is ordered by version ascending.
    /// </summary>
    public async Task<IEnumerable<Patient>> GetHistoryAsync(
        string id,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/patients/v1/{id}/history",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Updates a patient. The path must contain the most recent version to prevent races. Updating historic versions is not supported.
    /// </summary>
    public async Task<Patient> UpdateAsync(
        string id,
        string version,
        MutablePatient request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Put,
                Path = $"/patients/v1/{id}/{version}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Patient>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Sets a patient as deactivated. The path must contain the most recent version to prevent races. Dactivating historic versions is not supported. Subsequent updates via PUT to the patient will "reactivate" the patient and set the deactivated flag to false.
    /// </summary>
    public async System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Delete,
                Path = $"/patients/v1/{id}/{version}",
                Options = options
            }
        );
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
        }
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Searches for patients that match the query parameters.
    /// </summary>
    public async Task<IEnumerable<Patient>> SearchAsync(
        PatientsSearchRequest request,
        RequestOptions? options = null
    )
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
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }

    /// <summary>
    /// Scans up to 100 patient updates. The since query parameter is inclusive, and the result list is ordered by updatedAt descending.
    /// </summary>
    public async Task<IEnumerable<Patient>> ScanAsync(
        PatientScanRequest request,
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
                Path = "/patients/v1/updates/scan",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Patient>>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        throw new CandidApiException(
            $"Error with status code {response.StatusCode}",
            response.StatusCode,
            responseBody
        );
    }
}
