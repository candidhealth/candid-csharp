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
    ///         ChargeExternalId = "string",
    ///         EhrSourceUrl = "string",
    ///         PatientExternalId = "string",
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

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string chargeCaptureId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/charge_captures/v1/{chargeCaptureId}",
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

    /// <example>
    /// <code>
    /// await client.ChargeCapture.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ChargeCaptureUpdate
    ///     {
    ///         Data = new ChargeCaptureData(),
    ///         ChargeExternalId = "string",
    ///         EhrSourceUrl = "string",
    ///         PatientExternalId = "string",
    ///         Status = ChargeCaptureStatus.Planned,
    ///     }
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
    /// await client.ChargeCapture.V1.GetAllAsync(
    ///     new GetAllChargeCapturesRequest
    ///     {
    ///         Limit = 1,
    ///         Sort = ChargeCaptureSortField.CreatedAt,
    ///         SortDirection = Candid.Net.SortDirection.Asc,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///         PatientExternalId = "string",
    ///         Status = ChargeCaptureStatus.Planned,
    ///         ChargeExternalId = "string",
    ///         DateOfServiceMin = new DateOnly(2023, 1, 15),
    ///         DateOfServiceMax = new DateOnly(2023, 1, 15),
    ///         ClaimIds = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"],
    ///         BundleId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         BundleIds = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"],
    ///         BillingProviderNpis = ["string"],
    ///         ServiceFacilityName = "string",
    ///         PrimaryPayerIds = ["string"],
    ///         RenderingProviderNpis = ["string"],
    ///         RenderingProviderNames = ["string"],
    ///         SupervisingProviderNpis = ["string"],
    ///         SupervisingProviderNames = ["string"],
    ///         ExcludeChargesLinkedToClaims = true,
    ///         PatientExternalIdRankedSort = "string",
    ///         StatusRankedSort = ChargeCaptureStatus.Planned,
    ///         ChargeExternalIdRankedSort = "string",
    ///         DateOfServiceMinRankedSort = new DateOnly(2023, 1, 15),
    ///         DateOfServiceMaxRankedSort = new DateOnly(2023, 1, 15),
    ///         ClaimIdsRankedSort = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"],
    ///         BundleIdsRankedSort = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"],
    ///         BillingProviderNpisRankedSort = ["string"],
    ///         ServiceFacilityNameRankedSort = "string",
    ///         PrimaryPayerIdsRankedSort = ["string"],
    ///         RenderingProviderNpisRankedSort = ["string"],
    ///         RenderingProviderNamesRankedSort = ["string"],
    ///         SupervisingProviderNpisRankedSort = ["string"],
    ///         SupervisingProviderNamesRankedSort = ["string"],
    ///     }
    /// );
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
        _query["bundle_ids"] = request.BundleIds.Select(_value => _value.ToString()).ToList();
        _query["billing_provider_npis"] = request.BillingProviderNpis;
        _query["primary_payer_ids"] = request.PrimaryPayerIds;
        _query["rendering_provider_npis"] = request.RenderingProviderNpis;
        _query["rendering_provider_names"] = request.RenderingProviderNames;
        _query["supervising_provider_npis"] = request.SupervisingProviderNpis;
        _query["supervising_provider_names"] = request.SupervisingProviderNames;
        _query["claim_ids_ranked_sort"] = request
            .ClaimIdsRankedSort.Select(_value => _value.ToString())
            .ToList();
        _query["bundle_ids_ranked_sort"] = request
            .BundleIdsRankedSort.Select(_value => _value.ToString())
            .ToList();
        _query["billing_provider_npis_ranked_sort"] = request.BillingProviderNpisRankedSort;
        _query["primary_payer_ids_ranked_sort"] = request.PrimaryPayerIdsRankedSort;
        _query["rendering_provider_npis_ranked_sort"] = request.RenderingProviderNpisRankedSort;
        _query["rendering_provider_names_ranked_sort"] = request.RenderingProviderNamesRankedSort;
        _query["supervising_provider_npis_ranked_sort"] = request.SupervisingProviderNpisRankedSort;
        _query["supervising_provider_names_ranked_sort"] =
            request.SupervisingProviderNamesRankedSort;
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
        if (request.BundleId != null)
        {
            _query["bundle_id"] = request.BundleId.ToString();
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
        if (request.ServiceFacilityNameRankedSort != null)
        {
            _query["service_facility_name_ranked_sort"] = request.ServiceFacilityNameRankedSort;
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
    /// await client.ChargeCapture.V1.UpdatePostBilledChangeAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ChargeCapturePostBilledChangeUpdate { Resolved = true }
    /// );
    /// </code>
    /// </example>
    public async Task<ChargeCapturePostBilledChange> UpdatePostBilledChangeAsync(
        string chargeCaptureChangeId,
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
                Path = $"/api/charge_captures/v1/changes/{chargeCaptureChangeId}",
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
                return JsonUtils.Deserialize<ChargeCapturePostBilledChange>(responseBody)!;
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
