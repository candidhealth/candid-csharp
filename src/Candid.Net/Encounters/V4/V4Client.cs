using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.Encounters.V4;

public partial class V4Client
{
    private RawClient _client;

    internal V4Client(RawClient client)
    {
        _client = client;
    }

    /// <example><code>
    /// await client.Encounters.V4.GetAllAsync(
    ///     new GetAllEncountersRequest
    ///     {
    ///         Limit = 100,
    ///         ClaimStatus = ClaimStatus.BillerReceived,
    ///         Sort = EncounterSortOptions.CreatedAtAsc,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///         DateOfServiceMin = new DateOnly(2019, 8, 24),
    ///         DateOfServiceMax = new DateOnly(2019, 8, 25),
    ///         PrimaryPayerNames = "Medicare,Medicaid",
    ///         SearchTerm = "doe",
    ///         ExternalId = "123456",
    ///         DiagnosesUpdatedSince = new DateTime(2019, 08, 24, 14, 15, 22, 000),
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<EncounterPage> GetAllAsync(
        GetAllEncountersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["tag_ids"] = request.TagIds;
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.ClaimStatus != null)
        {
            _query["claim_status"] = request.ClaimStatus.Value.Stringify();
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.DateOfServiceMin != null)
        {
            _query["date_of_service_min"] = request.DateOfServiceMin.Value.ToString(
                Constants.DateFormat
            );
        }
        if (request.DateOfServiceMax != null)
        {
            _query["date_of_service_max"] = request.DateOfServiceMax.Value.ToString(
                Constants.DateFormat
            );
        }
        if (request.PrimaryPayerNames != null)
        {
            _query["primary_payer_names"] = request.PrimaryPayerNames;
        }
        if (request.SearchTerm != null)
        {
            _query["search_term"] = request.SearchTerm;
        }
        if (request.ExternalId != null)
        {
            _query["external_id"] = request.ExternalId;
        }
        if (request.DiagnosesUpdatedSince != null)
        {
            _query["diagnoses_updated_since"] = request.DiagnosesUpdatedSince.Value.ToString(
                Constants.DateTimeFormat
            );
        }
        if (request.WorkQueueId != null)
        {
            _query["work_queue_id"] = request.WorkQueueId;
        }
        if (request.BillableStatus != null)
        {
            _query["billable_status"] = request.BillableStatus.Value.Stringify();
        }
        if (request.ResponsibleParty != null)
        {
            _query["responsible_party"] = request.ResponsibleParty.Value.Stringify();
        }
        if (request.OwnerOfNextAction != null)
        {
            _query["owner_of_next_action"] = request.OwnerOfNextAction.Value.Stringify();
        }
        if (request.PatientExternalId != null)
        {
            _query["patient_external_id"] = request.PatientExternalId;
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/encounters/v4",
                    Query = _query,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<EncounterPage>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <example><code>
    /// await client.Encounters.V4.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task<Encounter> GetAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = string.Format(
                        "/api/encounters/v4/{0}",
                        ValueConvert.ToPathParameterString(encounterId)
                    ),
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Encounter>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <example><code>
    /// await client.Encounters.V4.CreateAsync(
    ///     new EncounterCreate
    ///     {
    ///         BillingProvider = new BillingProvider
    ///         {
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 ZipPlusFourCode = "zip_plus_four_code",
    ///                 Address1 = "address1",
    ///                 City = "city",
    ///                 State = State.Aa,
    ///                 ZipCode = "zip_code",
    ///             },
    ///             TaxId = "tax_id",
    ///             Npi = "npi",
    ///         },
    ///         Diagnoses = new List&lt;DiagnosisCreate&gt;()
    ///         {
    ///             new DiagnosisCreate { CodeType = DiagnosisTypeCode.Abf, Code = "code" },
    ///             new DiagnosisCreate { CodeType = DiagnosisTypeCode.Abf, Code = "code" },
    ///         },
    ///         PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///         RenderingProvider = new RenderingProvider { Npi = "npi" },
    ///         Patient = new PatientCreate
    ///         {
    ///             ExternalId = "external_id",
    ///             DateOfBirth = new DateOnly(2023, 1, 15),
    ///             Address = new StreetAddressShortZip
    ///             {
    ///                 Address1 = "address1",
    ///                 City = "city",
    ///                 State = State.Aa,
    ///                 ZipCode = "zip_code",
    ///             },
    ///             FirstName = "first_name",
    ///             LastName = "last_name",
    ///             Gender = Candid.Net.Individual.Gender.Male,
    ///         },
    ///         ResponsibleParty = ResponsiblePartyType.InsurancePay,
    ///         ExternalId = "external_id",
    ///         PatientAuthorizedRelease = true,
    ///         BenefitsAssignedToProvider = true,
    ///         ProviderAcceptsAssignment = true,
    ///         BillableStatus = BillableStatusType.Billable,
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<Encounter> CreateAsync(
        EncounterCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/encounters/v4",
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Encounter>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <summary>
    /// Create an encounter from a pre-encounter patient and appointment. This endpoint is intended to be used by consumers who are managing
    /// patients and appointments in the pre-encounter service and is currently under development. Consumers who are not taking advantage
    /// of the pre-encounter service should use the standard create endpoint.
    ///
    /// The endpoint will create an encounter from the provided fields, pulling information from the provided patient and appointment objects
    /// where applicable. In particular, the following fields are populated from the patient and appointment objects:
    ///   - Patient
    ///   - Referring Provider
    ///   - Subscriber Primary
    ///   - Subscriber Secondary
    ///   - Referral Number
    ///   - Responsible Party
    ///   - Guarantor
    ///
    /// Utilizing this endpoint opts you into automatic updating of the encounter when the patient or appointment is updated, assuming the
    /// encounter has not already been submitted or adjudicated.
    /// </summary>
    /// <example><code>
    /// await client.Encounters.V4.CreateFromPreEncounterPatientAsync(
    ///     new EncounterCreateFromPreEncounter
    ///     {
    ///         RenderingProvider = new RenderingProvider { Npi = "npi" },
    ///         PlaceOfServiceCode = FacilityTypeCode.Pharmacy,
    ///         Diagnoses = new List&lt;DiagnosisCreate&gt;()
    ///         {
    ///             new DiagnosisCreate { CodeType = DiagnosisTypeCode.Abf, Code = "code" },
    ///             new DiagnosisCreate { CodeType = DiagnosisTypeCode.Abf, Code = "code" },
    ///         },
    ///         PreEncounterPatientId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         PreEncounterAppointmentIds = new List&lt;string&gt;()
    ///         {
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         },
    ///         BillingProvider = new BillingProvider
    ///         {
    ///             Address = new StreetAddressLongZip
    ///             {
    ///                 ZipPlusFourCode = "zip_plus_four_code",
    ///                 Address1 = "address1",
    ///                 City = "city",
    ///                 State = State.Aa,
    ///                 ZipCode = "zip_code",
    ///             },
    ///             TaxId = "tax_id",
    ///             Npi = "npi",
    ///         },
    ///         ExternalId = "external_id",
    ///         PatientAuthorizedRelease = true,
    ///         BenefitsAssignedToProvider = true,
    ///         ProviderAcceptsAssignment = true,
    ///         BillableStatus = BillableStatusType.Billable,
    ///     }
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<Encounter> CreateFromPreEncounterPatientAsync(
        EncounterCreateFromPreEncounter request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/encounters/v4/create-from-pre-encounter",
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Encounter>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    /// <example><code>
    /// await client.Encounters.V4.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new EncounterUpdate()
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task<Encounter> UpdateAsync(
        string encounterId,
        EncounterUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "/api/encounters/v4/{0}",
                        ValueConvert.ToPathParameterString(encounterId)
                    ),
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<Encounter>(responseBody)!;
            }
            catch (JsonException e)
            {
                throw new CandidException("Failed to deserialize response", e);
            }
        }

        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }
}
