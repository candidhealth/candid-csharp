using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;
using global::Candid.Net.EncountersUniversal;

namespace Candid.Net.Encounters.V4;

public partial class V4Client : IV4Client
{
    private readonly RawClient _client;

    internal V4Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<EncounterPage>
    > GetAllAsyncCore(
        GetAllEncountersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 17)
            .Add("limit", request.Limit)
            .Add("claim_status", request.ClaimStatus)
            .Add("sort", request.Sort)
            .Add("page_token", request.PageToken)
            .Add("date_of_service_min", request.DateOfServiceMin)
            .Add("date_of_service_max", request.DateOfServiceMax)
            .Add("primary_payer_names", request.PrimaryPayerNames)
            .Add("search_term", request.SearchTerm)
            .Add("external_id", request.ExternalId)
            .Add("diagnoses_updated_since", request.DiagnosesUpdatedSince)
            .Add("tag_ids", request.TagIds)
            .Add("work_queue_id", request.WorkQueueId)
            .Add("billable_status", request.BillableStatus)
            .Add("responsible_party", request.ResponsibleParty)
            .Add("owner_of_next_action", request.OwnerOfNextAction)
            .Add("patient_external_id", request.PatientExternalId)
            .Add("include_merged_patient_data", request.IncludeMergedPatientData)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/encounters/v4",
                    QueryString = _queryString,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<EncounterPage>(responseBody)!;
                return new WithRawResponse<EncounterPage>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<WithRawResponse<Encounter>> GetAsyncCore(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
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
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<Encounter>(responseBody)!;
                return new WithRawResponse<Encounter>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<Encounter>
    > CreateUniversalAsyncCore(
        UniversalEncounterCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/encounters/v4/universal",
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<Encounter>(responseBody)!;
                return new WithRawResponse<Encounter>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<WithRawResponse<Encounter>> CreateAsyncCore(
        EncounterCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/encounters/v4",
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<Encounter>(responseBody)!;
                return new WithRawResponse<Encounter>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<Encounter>
    > CreateFromPreEncounterPatientUniversalAsyncCore(
        UniversalEncounterCreateFromPreEncounter request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/encounters/v4/create-from-pre-encounter/universal",
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<Encounter>(responseBody)!;
                return new WithRawResponse<Encounter>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<Encounter>
    > CreateFromPreEncounterPatientAsyncCore(
        EncounterCreateFromPreEncounter request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/encounters/v4/create-from-pre-encounter",
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<Encounter>(responseBody)!;
                return new WithRawResponse<Encounter>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<Encounter>
    > UpdateUniversalAsyncCore(
        string encounterId,
        UniversalEncounterUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethodExtensions.Patch,
                    Path = string.Format(
                        "/api/encounters/v4/{0}/universal",
                        ValueConvert.ToPathParameterString(encounterId)
                    ),
                    Body = request,
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<Encounter>(responseBody)!;
                return new WithRawResponse<Encounter>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
    }

    private async global::System.Threading.Tasks.Task<WithRawResponse<Encounter>> UpdateAsyncCore(
        string encounterId,
        EncounterUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new global::Candid.Net.Core.HeadersBuilder.Builder()
            .Add(_client.Options.Headers)
            .Add(_client.Options.AdditionalHeaders)
            .Add(options?.AdditionalHeaders)
            .BuildAsync()
            .ConfigureAwait(false);
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
                    Headers = _headers,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<Encounter>(responseBody)!;
                return new WithRawResponse<Encounter>()
                {
                    Data = responseData,
                    RawResponse = new RawResponse()
                    {
                        StatusCode = response.Raw.StatusCode,
                        Url = response.Raw.RequestMessage?.RequestUri ?? new Uri("about:blank"),
                        Headers = ResponseHeaders.FromHttpResponseMessage(response.Raw),
                    },
                };
            }
            catch (JsonException e)
            {
                throw new CandidApiException(
                    "Failed to deserialize response",
                    response.StatusCode,
                    responseBody,
                    e
                );
            }
        }
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            throw new CandidApiException(
                $"Error with status code {response.StatusCode}",
                response.StatusCode,
                responseBody
            );
        }
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
    public WithRawResponseTask<EncounterPage> GetAllAsync(
        GetAllEncountersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<EncounterPage>(
            GetAllAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Encounters.V4.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<Encounter> GetAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Encounter>(
            GetAsyncCore(encounterId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Notice: The UB-04 Data File, 2025, is copyrighted by American Hospital Association (AHA), Chicago, Illinois.
    /// No portion of the THE UB-04 Data File, may be reproduced, stored in a retrieval system, or transmitted,
    /// in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without prior
    /// express, written consent of AHA.
    /// </summary>
    /// <example><code>
    /// await client.Encounters.V4.CreateUniversalAsync(
    ///     new UniversalEncounterCreate
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
    ///         SubmissionExpectation = EncounterSubmissionExpectation.TargetProfessional,
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
    ///             Gender = global::Candid.Net.Individual.Gender.Male,
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
    public WithRawResponseTask<Encounter> CreateUniversalAsync(
        UniversalEncounterCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Encounter>(
            CreateUniversalAsyncCore(request, options, cancellationToken)
        );
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
    ///             Gender = global::Candid.Net.Individual.Gender.Male,
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
    public WithRawResponseTask<Encounter> CreateAsync(
        EncounterCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Encounter>(
            CreateAsyncCore(request, options, cancellationToken)
        );
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
    ///
    /// Notice: The UB-04 Data File, 2025, is copyrighted by American Hospital Association (AHA), Chicago, Illinois.
    /// No portion of the THE UB-04 Data File, may be reproduced, stored in a retrieval system, or transmitted,
    /// in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without prior
    /// express, written consent of AHA.
    /// </summary>
    /// <example><code>
    /// await client.Encounters.V4.CreateFromPreEncounterPatientUniversalAsync(
    ///     new UniversalEncounterCreateFromPreEncounter
    ///     {
    ///         SubmissionExpectation = EncounterSubmissionExpectation.TargetProfessional,
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
    public WithRawResponseTask<Encounter> CreateFromPreEncounterPatientUniversalAsync(
        UniversalEncounterCreateFromPreEncounter request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Encounter>(
            CreateFromPreEncounterPatientUniversalAsyncCore(request, options, cancellationToken)
        );
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
    public WithRawResponseTask<Encounter> CreateFromPreEncounterPatientAsync(
        EncounterCreateFromPreEncounter request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Encounter>(
            CreateFromPreEncounterPatientAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Notice: The UB-04 Data File, 2025, is copyrighted by American Hospital Association (AHA), Chicago, Illinois.
    /// No portion of the THE UB-04 Data File, may be reproduced, stored in a retrieval system, or transmitted,
    /// in any form or by any means, electronic, mechanical, photocopying, recording, or otherwise, without prior
    /// express, written consent of AHA.
    /// </summary>
    /// <example><code>
    /// await client.Encounters.V4.UpdateUniversalAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new UniversalEncounterUpdate()
    /// );
    /// </code></example>
    public WithRawResponseTask<Encounter> UpdateUniversalAsync(
        string encounterId,
        UniversalEncounterUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Encounter>(
            UpdateUniversalAsyncCore(encounterId, request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.Encounters.V4.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new EncounterUpdate()
    /// );
    /// </code></example>
    public WithRawResponseTask<Encounter> UpdateAsync(
        string encounterId,
        EncounterUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<Encounter>(
            UpdateAsyncCore(encounterId, request, options, cancellationToken)
        );
    }
}
