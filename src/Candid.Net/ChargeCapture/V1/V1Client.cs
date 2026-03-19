using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.ChargeCapture.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<ChargeCapture>
    > CreateAsyncCore(
        CreateChargeCaptureRequest request,
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
                    Path = "/api/charge_captures/v1",
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
                var responseData = JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
                return new WithRawResponse<ChargeCapture>()
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
        WithRawResponse<ChargeCapture>
    > CreateFromPreEncounterPatientAsyncCore(
        CreateChargeCaptureFromPreEncounterRequest request,
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
                    Path = "/api/charge_captures/v1/create-from-pre-encounter",
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
                var responseData = JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
                return new WithRawResponse<ChargeCapture>()
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
        WithRawResponse<IEnumerable<ChargeCapturePostBilledChange>>
    > UpdatePostBilledChangesAsyncCore(
        ChargeCapturePostBilledChangeUpdate request,
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
                    Path = "/api/charge_captures/v1/changes",
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
                var responseData = JsonUtils.Deserialize<
                    IEnumerable<ChargeCapturePostBilledChange>
                >(responseBody)!;
                return new WithRawResponse<IEnumerable<ChargeCapturePostBilledChange>>()
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
        WithRawResponse<ChargeCapture>
    > UpdateAsyncCore(
        string chargeCaptureId,
        ChargeCaptureUpdate request,
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
                        "/api/charge_captures/v1/{0}",
                        ValueConvert.ToPathParameterString(chargeCaptureId)
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
                var responseData = JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
                return new WithRawResponse<ChargeCapture>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<ChargeCapture>> GetAsyncCore(
        string chargeCaptureId,
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
                        "/api/charge_captures/v1/{0}",
                        ValueConvert.ToPathParameterString(chargeCaptureId)
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
                var responseData = JsonUtils.Deserialize<ChargeCapture>(responseBody)!;
                return new WithRawResponse<ChargeCapture>()
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
        WithRawResponse<ChargeCapturePage>
    > GetAllAsyncCore(
        GetAllChargeCapturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new global::Candid.Net.Core.QueryStringBuilder.Builder(capacity: 45)
            .Add("limit", request.Limit)
            .Add("sort", request.Sort)
            .Add("sort_direction", request.SortDirection)
            .Add("page_token", request.PageToken)
            .Add("patient_external_id", request.PatientExternalId)
            .Add("status", request.Status)
            .Add("charge_external_id", request.ChargeExternalId)
            .Add("date_of_service_min", request.DateOfServiceMin)
            .Add("date_of_service_max", request.DateOfServiceMax)
            .Add("claim_ids", request.ClaimIds)
            .Add("claim_creation_ids", request.ClaimCreationIds)
            .Add("billing_provider_npis", request.BillingProviderNpis)
            .Add("service_facility_name", request.ServiceFacilityName)
            .Add("primary_payer_ids", request.PrimaryPayerIds)
            .Add("rendering_provider_npis", request.RenderingProviderNpis)
            .Add("rendering_provider_names", request.RenderingProviderNames)
            .Add("supervising_provider_npis", request.SupervisingProviderNpis)
            .Add("supervising_provider_names", request.SupervisingProviderNames)
            .Add("claim_creation_category", request.ClaimCreationCategory)
            .Add("tags", request.Tags)
            .Add("primary_payer_names", request.PrimaryPayerNames)
            .Add("patient_names", request.PatientNames)
            .Add("exclude_charges_linked_to_claims", request.ExcludeChargesLinkedToClaims)
            .Add("patient_external_id_ranked_sort", request.PatientExternalIdRankedSort)
            .Add("status_ranked_sort", request.StatusRankedSort)
            .Add("charge_external_id_ranked_sort", request.ChargeExternalIdRankedSort)
            .Add("date_of_service_min_ranked_sort", request.DateOfServiceMinRankedSort)
            .Add("date_of_service_max_ranked_sort", request.DateOfServiceMaxRankedSort)
            .Add("search_term", request.SearchTerm)
            .Add("billable_status", request.BillableStatus)
            .Add("responsible_party", request.ResponsibleParty)
            .Add("claim_ids_ranked_sort", request.ClaimIdsRankedSort)
            .Add("claim_creation_ids_ranked_sort", request.ClaimCreationIdsRankedSort)
            .Add("billing_provider_npis_ranked_sort", request.BillingProviderNpisRankedSort)
            .Add("service_facility_name_ranked_sort", request.ServiceFacilityNameRankedSort)
            .Add("primary_payer_ids_ranked_sort", request.PrimaryPayerIdsRankedSort)
            .Add("rendering_provider_npis_ranked_sort", request.RenderingProviderNpisRankedSort)
            .Add("rendering_provider_names_ranked_sort", request.RenderingProviderNamesRankedSort)
            .Add("supervising_provider_npis_ranked_sort", request.SupervisingProviderNpisRankedSort)
            .Add(
                "supervising_provider_names_ranked_sort",
                request.SupervisingProviderNamesRankedSort
            )
            .Add("claim_status", request.ClaimStatus)
            .Add("claim_creation_category_ranked_sort", request.ClaimCreationCategoryRankedSort)
            .Add("tags_ranked_sort", request.TagsRankedSort)
            .Add("primary_payer_names_ranked_sort", request.PrimaryPayerNamesRankedSort)
            .Add("patient_names_ranked_sort", request.PatientNamesRankedSort)
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
                    Path = "/api/charge_captures/v1",
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
                var responseData = JsonUtils.Deserialize<ChargeCapturePage>(responseBody)!;
                return new WithRawResponse<ChargeCapturePage>()
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
    /// await client.ChargeCapture.V1.CreateAsync(
    ///     new CreateChargeCaptureRequest
    ///     {
    ///         Data = new ChargeCaptureData(),
    ///         ChargeExternalId = "charge_external_id",
    ///         PatientExternalId = "patient_external_id",
    ///         Status = ChargeCaptureStatus.Planned,
    ///     }
    /// );
    /// </code></example>
    public WithRawResponseTask<ChargeCapture> CreateAsync(
        CreateChargeCaptureRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ChargeCapture>(
            CreateAsyncCore(request, options, cancellationToken)
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
    /// <example><code>
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
    /// </code></example>
    public WithRawResponseTask<ChargeCapture> CreateFromPreEncounterPatientAsync(
        CreateChargeCaptureFromPreEncounterRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ChargeCapture>(
            CreateFromPreEncounterPatientAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
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
    /// </code></example>
    public WithRawResponseTask<
        IEnumerable<ChargeCapturePostBilledChange>
    > UpdatePostBilledChangesAsync(
        ChargeCapturePostBilledChangeUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<ChargeCapturePostBilledChange>>(
            UpdatePostBilledChangesAsyncCore(request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.ChargeCapture.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ChargeCaptureUpdate()
    /// );
    /// </code></example>
    public WithRawResponseTask<ChargeCapture> UpdateAsync(
        string chargeCaptureId,
        ChargeCaptureUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ChargeCapture>(
            UpdateAsyncCore(chargeCaptureId, request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.ChargeCapture.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<ChargeCapture> GetAsync(
        string chargeCaptureId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ChargeCapture>(
            GetAsyncCore(chargeCaptureId, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.ChargeCapture.V1.GetAllAsync(new GetAllChargeCapturesRequest());
    /// </code></example>
    public WithRawResponseTask<ChargeCapturePage> GetAllAsync(
        GetAllChargeCapturesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ChargeCapturePage>(
            GetAllAsyncCore(request, options, cancellationToken)
        );
    }
}
