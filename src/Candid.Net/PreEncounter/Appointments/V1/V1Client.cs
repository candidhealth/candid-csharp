using System.Net.Http;
using System.Text.Json;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Appointments.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Adds an appointment. VersionConflictError is returned when the placer_appointment_id is already in use.
    /// </summary>
    public async Task<Appointment> CreateAsync(
        MutableAppointment request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/appointments/v1",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Appointment>(responseBody)!;
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
    /// Gets an appointment.
    /// </summary>
    public async Task<Appointment> GetAsync(string id, RequestOptions? options = null)
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/appointments/v1/{id}",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Appointment>(responseBody)!;
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
    /// Gets an appointment along with it's full history. The return list is ordered by version ascending.
    /// </summary>
    public async Task<IEnumerable<Appointment>> GetHistoryAsync(
        string id,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/appointments/v1/{id}/history",
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Appointment>>(responseBody)!;
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
    /// Updates an appointment. The path must contain the most recent version to prevent race conditions. Updating historic versions is not supported.
    /// </summary>
    public async Task<Appointment> UpdateAsync(
        string id,
        string version,
        MutableAppointment request,
        RequestOptions? options = null
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Put,
                Path = $"/appointments/v1/{id}/{version}",
                Body = request,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Appointment>(responseBody)!;
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
    /// Sets an appointment as deactivated. The path must contain the most recent version to prevent race conditions. Deactivating historic versions is not supported. Subsequent updates via PUT to the appointment will "reactivate" the appointment and set the deactivated flag to false.
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
                Path = $"/appointments/v1/{id}/{version}",
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
    /// Searches for appointments that match the query parameters.
    /// </summary>
    public async Task<IEnumerable<Appointment>> GetMultiAsync(
        AppointmentsSearchRequest request,
        RequestOptions? options = null
    )
    {
        var _query = new Dictionary<string, object>() { };
        if (request.CheckedIn != null)
        {
            _query["checked_in"] = request.CheckedIn.ToString();
        }
        if (request.PatientId != null)
        {
            _query["patient_id"] = request.PatientId;
        }
        if (request.MinStartTimestamp != null)
        {
            _query["min_start_timestamp"] = request.MinStartTimestamp.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.MaxStartTimestamp != null)
        {
            _query["max_start_timestamp"] = request.MaxStartTimestamp.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.PlacerAppointmentId != null)
        {
            _query["placer_appointment_id"] = request.PlacerAppointmentId;
        }
        if (request.WorkQueue != null)
        {
            _query["work_queue"] = JsonSerializer.Serialize(request.WorkQueue.Value);
        }
        if (request.SortField != null)
        {
            _query["sort_field"] = JsonSerializer.Serialize(request.SortField.Value);
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = JsonSerializer.Serialize(request.SortDirection.Value);
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/appointments/v1",
                Query = _query,
                Options = options
            }
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Appointment>>(responseBody)!;
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