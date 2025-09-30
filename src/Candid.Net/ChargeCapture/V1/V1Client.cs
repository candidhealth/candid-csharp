using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCapture.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.CreateAsync(
    ///     new CreateChargeCaptureRequest
    ///     {
    ///         Data = new ChargeCaptureData(),
    ///         ChargeExternalId = "charge_external_id",
    ///         PatientExternalId = "patient_external_id",
    ///         Status = ChargeCaptureStatus.Planned,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ChargeCapture> CreateAsync(
        CreateChargeCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/charge_captures/v1",
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
                return JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
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
    /// Create a Charge Capture from a pre-encounter patient and appointment. This endpoint is intended to be used by consumers who are managing
    /// patients and appointments in the pre-encounter service and is currently under development. Consumers who are not taking advantage
    /// of the pre-encounter service should use the standard create endpoint.
    ///
    /// At encounter creation time, information from the provided patient and appointment objects will be populated
    /// where applicable. In particular, the following fields are populated from the patient and appointment objects:
    ///   - Patient
    ///   - Referring Provider
    ///   - Subscriber Primary
    ///   - Subscriber Secondary
    ///   - Referral Number
    ///   - Responsible Party
    ///   - Guarantor
    ///
    /// Note that these fields should not be populated in the ChargeCaptureData property of this endpoint, as they will be overwritten at encounter creation time.
    ///
    /// Utilizing this endpoint opts you into automatic updating of the encounter when the patient or appointment is updated, assuming the
    /// encounter has not already been submitted or adjudicated.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.CreateFromPreEncounterPatientAsync(
    ///     new CreateChargeCaptureFromPreEncounterRequest
    ///     {
    ///         Data = new ChargeCaptureData(),
    ///         ChargeExternalId = "charge_external_id",
    ///         PreEncounterPatientId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         PreEncounterAppointmentIds = new List&lt;string&gt;()
    ///         {
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         },
    ///         Status = ChargeCaptureStatus.Planned,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ChargeCapture> CreateFromPreEncounterPatientAsync(
        CreateChargeCaptureFromPreEncounterRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/charge_captures/v1/create-from-pre-encounter",
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
                return JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
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

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ChargeCaptureUpdate()
    /// );
    /// </code>
    /// </example>
    public async Task<ChargeCapture> UpdateAsync(
        string chargeCaptureId,
        ChargeCaptureUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/charge_captures/v1/{chargeCaptureId}",
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
                return JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
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

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<ChargeCapture> GetAsync(
        string chargeCaptureId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/charge_captures/v1/{chargeCaptureId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
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

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.GetAllAsync(new GetAllChargeCapturesRequest());
    /// </code>
    /// </example>
    public async Task<ChargeCapturePage> GetAllAsync(
        GetAllChargeCapturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["claim_ids"] = request.ClaimIds.Select(_value => _value.ToString()).ToList();
        _query["claim_creation_ids"] = request
            .ClaimCreationIds.Select(_value => _value.ToString())
            .ToList();
        _query["billing_provider_npis"] = request.BillingProviderNpis;
        _query["primary_payer_ids"] = request.PrimaryPayerIds;
        _query["rendering_provider_npis"] = request.RenderingProviderNpis;
        _query["rendering_provider_names"] = request.RenderingProviderNames;
        _query["supervising_provider_npis"] = request.SupervisingProviderNpis;
        _query["supervising_provider_names"] = request.SupervisingProviderNames;
        _query["claim_creation_category"] = request.ClaimCreationCategory;
        _query["tags"] = request.Tags;
        _query["primary_payer_names"] = request.PrimaryPayerNames;
        _query["patient_names"] = request.PatientNames;
        _query["claim_ids_ranked_sort"] = request
            .ClaimIdsRankedSort.Select(_value => _value.ToString())
            .ToList();
        _query["claim_creation_ids_ranked_sort"] = request
            .ClaimCreationIdsRankedSort.Select(_value => _value.ToString())
            .ToList();
        _query["billing_provider_npis_ranked_sort"] = request.BillingProviderNpisRankedSort;
        _query["primary_payer_ids_ranked_sort"] = request.PrimaryPayerIdsRankedSort;
        _query["rendering_provider_npis_ranked_sort"] = request.RenderingProviderNpisRankedSort;
        _query["rendering_provider_names_ranked_sort"] = request.RenderingProviderNamesRankedSort;
        _query["supervising_provider_npis_ranked_sort"] = request.SupervisingProviderNpisRankedSort;
        _query["supervising_provider_names_ranked_sort"] =
            request.SupervisingProviderNamesRankedSort;
        _query["claim_creation_category_ranked_sort"] = request.ClaimCreationCategoryRankedSort;
        _query["tags_ranked_sort"] = request.TagsRankedSort;
        _query["primary_payer_names_ranked_sort"] = request.PrimaryPayerNamesRankedSort;
        _query["patient_names_ranked_sort"] = request.PatientNamesRankedSort;
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.PatientExternalId != null)
        {
            _query["patient_external_id"] = request.PatientExternalId;
        }
        if (request.Status != null)
        {
            _query["status"] = request.Status.Value.Stringify();
        }
        if (request.ChargeExternalId != null)
        {
            _query["charge_external_id"] = request.ChargeExternalId;
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
        if (request.ServiceFacilityName != null)
        {
            _query["service_facility_name"] = request.ServiceFacilityName;
        }
        if (request.ExcludeChargesLinkedToClaims != null)
        {
            _query["exclude_charges_linked_to_claims"] =
                request.ExcludeChargesLinkedToClaims.ToString();
        }
        if (request.PatientExternalIdRankedSort != null)
        {
            _query["patient_external_id_ranked_sort"] = request.PatientExternalIdRankedSort;
        }
        if (request.StatusRankedSort != null)
        {
            _query["status_ranked_sort"] = request.StatusRankedSort.Value.Stringify();
        }
        if (request.ChargeExternalIdRankedSort != null)
        {
            _query["charge_external_id_ranked_sort"] = request.ChargeExternalIdRankedSort;
        }
        if (request.DateOfServiceMinRankedSort != null)
        {
            _query["date_of_service_min_ranked_sort"] =
                request.DateOfServiceMinRankedSort.Value.ToString(Constants.DateFormat);
        }
        if (request.DateOfServiceMaxRankedSort != null)
        {
            _query["date_of_service_max_ranked_sort"] =
                request.DateOfServiceMaxRankedSort.Value.ToString(Constants.DateFormat);
        }
        if (request.SearchTerm != null)
        {
            _query["search_term"] = request.SearchTerm;
        }
        if (request.BillableStatus != null)
        {
            _query["billable_status"] = request.BillableStatus.Value.Stringify();
        }
        if (request.ResponsibleParty != null)
        {
            _query["responsible_party"] = request.ResponsibleParty.Value.Stringify();
        }
        if (request.ServiceFacilityNameRankedSort != null)
        {
            _query["service_facility_name_ranked_sort"] = request.ServiceFacilityNameRankedSort;
        }
        if (request.ClaimStatus != null)
        {
            _query["claim_status"] = request.ClaimStatus.Value.Stringify();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/charge_captures/v1",
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
                return JsonUtils.Deserialize<ChargeCapturePage>(responseBody)!;
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

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.UpdatePostBilledChangesAsync(
    ///     new ChargeCapturePostBilledChangeUpdate
    ///     {
    ///         ChargeCaptureChangeIds = new List&lt;string&gt;()
    ///         {
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///             "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         },
    ///         Resolved = true,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<IEnumerable<ChargeCapturePostBilledChange>> UpdatePostBilledChangesAsync(
        ChargeCapturePostBilledChangeUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = "/api/charge_captures/v1/changes/",
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
                return JsonUtils.Deserialize<IEnumerable<ChargeCapturePostBilledChange>>(
                    responseBody
                )!;
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
