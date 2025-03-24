using System.Net.Http;
using System.Text.Json;
using System.Threading;
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
    /// <example>
    /// <code>
    /// await client.PreEncounter.Appointments.V1.CreateAsync(
    ///     new MutableAppointment
    ///     {
    ///         PatientId = "string",
    ///         StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         Status = AppointmentStatus.Pending,
    ///         ServiceDuration = 1,
    ///         Services = new List&lt;Service&gt;()
    ///         {
    ///             new Service
    ///             {
    ///                 UniversalServiceIdentifier = UniversalServiceIdentifier.MdVisit,
    ///                 StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///             },
    ///         },
    ///         PlacerAppointmentId = "string",
    ///         AttendingDoctor = new ExternalProvider
    ///         {
    ///             Name = new HumanName
    ///             {
    ///                 Family = "string",
    ///                 Given = new List&lt;string&gt;() { "string" },
    ///                 Use = NameUse.Usual,
    ///                 Period = new Period(),
    ///                 Suffix = "string",
    ///             },
    ///             Type = ExternalProviderType.Primary,
    ///             Npi = "string",
    ///             Telecoms = new List&lt;ContactPoint&gt;()
    ///             {
    ///                 new ContactPoint { Value = "string", Use = ContactPointUse.Home },
    ///             },
    ///             Addresses = new List&lt;Candid.Net.PreEncounter.Address&gt;() { },
    ///             Period = new Period(),
    ///             CanonicalId = "string",
    ///             Fax = "string",
    ///         },
    ///         EstimatedCopayCents = 1,
    ///         EstimatedPatientResponsibilityCents = 1,
    ///         PatientDepositCents = 1,
    ///         CheckedInTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         Notes = "string",
    ///         LocationResourceId = "string",
    ///         AutomatedEligibilityCheckComplete = true,
    ///         WorkQueue = AppointmentWorkQueue.EmergentIssue,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Appointment> CreateAsync(
        MutableAppointment request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/appointments/v1",
                Body = request,
                Options = options,
            },
            cancellationToken
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
    /// Gets all Visits within a given time range. The return list is ordered by start_time ascending.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Appointments.V1.GetVisitsAsync(
    ///     new VisitsRequest
    ///     {
    ///         PageToken = "string",
    ///         Limit = 1,
    ///         SortField = "string",
    ///         SortDirection = Candid.Net.PreEncounter.SortDirection.Asc,
    ///         Filters = "string",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<VisitsPage> GetVisitsAsync(
        VisitsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.SortField != null)
        {
            _query["sort_field"] = request.SortField;
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        if (request.Filters != null)
        {
            _query["filters"] = request.Filters;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/appointments/v1/visits",
                Query = _query,
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<VisitsPage>(responseBody)!;
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
    /// <example>
    /// <code>
    /// await client.PreEncounter.Appointments.V1.GetAsync("string");
    /// </code>
    /// </example>
    public async Task<Appointment> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/appointments/v1/{id}",
                Options = options,
            },
            cancellationToken
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
    /// <example>
    /// <code>
    /// await client.PreEncounter.Appointments.V1.GetHistoryAsync("string");
    /// </code>
    /// </example>
    public async Task<IEnumerable<Appointment>> GetHistoryAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/appointments/v1/{id}/history",
                Options = options,
            },
            cancellationToken
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
    /// <example>
    /// <code>
    /// await client.PreEncounter.Appointments.V1.UpdateAsync(
    ///     "string",
    ///     "string",
    ///     new MutableAppointment
    ///     {
    ///         PatientId = "string",
    ///         StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         Status = AppointmentStatus.Pending,
    ///         ServiceDuration = 1,
    ///         Services = new List&lt;Service&gt;()
    ///         {
    ///             new Service
    ///             {
    ///                 UniversalServiceIdentifier = UniversalServiceIdentifier.MdVisit,
    ///                 StartTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///             },
    ///         },
    ///         PlacerAppointmentId = "string",
    ///         AttendingDoctor = new ExternalProvider
    ///         {
    ///             Name = new HumanName
    ///             {
    ///                 Family = "string",
    ///                 Given = new List&lt;string&gt;() { "string" },
    ///                 Use = NameUse.Usual,
    ///                 Period = new Period(),
    ///                 Suffix = "string",
    ///             },
    ///             Type = ExternalProviderType.Primary,
    ///             Npi = "string",
    ///             Telecoms = new List&lt;ContactPoint&gt;()
    ///             {
    ///                 new ContactPoint { Value = "string", Use = ContactPointUse.Home },
    ///             },
    ///             Addresses = new List&lt;Candid.Net.PreEncounter.Address&gt;() { },
    ///             Period = new Period(),
    ///             CanonicalId = "string",
    ///             Fax = "string",
    ///         },
    ///         EstimatedCopayCents = 1,
    ///         EstimatedPatientResponsibilityCents = 1,
    ///         PatientDepositCents = 1,
    ///         CheckedInTimestamp = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         Notes = "string",
    ///         LocationResourceId = "string",
    ///         AutomatedEligibilityCheckComplete = true,
    ///         WorkQueue = AppointmentWorkQueue.EmergentIssue,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Appointment> UpdateAsync(
        string id,
        string version,
        MutableAppointment request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Put,
                Path = $"/appointments/v1/{id}/{version}",
                Body = request,
                Options = options,
            },
            cancellationToken
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
    /// Scans up to 100 appointment updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Appointments.V1.ScanAsync(
    ///     new AppointmentScanRequest { Since = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
    /// );
    /// </code>
    /// </example>
    public async Task<IEnumerable<Appointment>> ScanAsync(
        AppointmentScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["since"] = request.Since.ToString(Constants.DateTimeFormat);
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/appointments/v1/updates/scan",
                Query = _query,
                Options = options,
            },
            cancellationToken
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
    /// Sets an appointment as deactivated. The path must contain the most recent version to prevent race conditions. Deactivating historic versions is not supported. Subsequent updates via PUT to the appointment will "reactivate" the appointment and set the deactivated flag to false.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Appointments.V1.DeactivateAsync("string", "string");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Delete,
                Path = $"/appointments/v1/{id}/{version}",
                Options = options,
            },
            cancellationToken
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
}
