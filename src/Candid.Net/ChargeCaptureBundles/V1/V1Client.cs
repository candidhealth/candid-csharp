using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.ChargeCaptureBundles.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.ChargeCaptureBundles.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<ChargeCaptureClaimCreation> GetAsync(
        string chargeCaptureClaimCreationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/charge_capture_claim_creation/v1/{chargeCaptureClaimCreationId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCaptureClaimCreation>(responseBody)!;
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
    /// await client.ChargeCaptureBundles.V1.GetSummaryAsync();
    /// </code>
    /// </example>
    public async Task<ChargeCaptureClaimCreationSummary> GetSummaryAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/charge_capture_claim_creation/v1/all/summary",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCaptureClaimCreationSummary>(responseBody)!;
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
    /// await client.ChargeCaptureBundles.V1.GetAllAsync(
    ///     new GetAllChargeCaptureClaimCreationsRequest
    ///     {
    ///         Limit = 1,
    ///         Sort = ChargeCaptureClaimCreationSortField.CreatedAt,
    ///         SortDirection = Candid.Net.SortDirection.Asc,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///         PatientExternalId = "string",
    ///         ClaimCreationStatus = ChargeCaptureClaimCreationStatus.NotStarted,
    ///         ChargeStatus = ChargeCaptureStatus.Planned,
    ///         ChargeExternalId = "string",
    ///         DateOfServiceMin = new DateOnly(2023, 1, 15),
    ///         DateOfServiceMax = new DateOnly(2023, 1, 15),
    ///         ClaimIds = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"],
    ///         ClaimCreationIds = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"],
    ///         BillingProviderNpis = ["string"],
    ///         ServiceFacilityName = "string",
    ///         PrimaryPayerIds = ["string"],
    ///         RenderingProviderNpis = ["string"],
    ///         RenderingProviderNames = ["string"],
    ///         SupervisingProviderNpis = ["string"],
    ///         SupervisingProviderNames = ["string"],
    ///         HasChargeCaptureUpdates = true,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ChargeCaptureClaimCreationPage> GetAllAsync(
        GetAllChargeCaptureClaimCreationsRequest request,
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
        if (request.ClaimCreationStatus != null)
        {
            _query["claim_creation_status"] = request.ClaimCreationStatus.Value.Stringify();
        }
        if (request.ChargeStatus != null)
        {
            _query["charge_status"] = request.ChargeStatus.Value.Stringify();
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
        if (request.HasChargeCaptureUpdates != null)
        {
            _query["has_charge_capture_updates"] = request.HasChargeCaptureUpdates.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/charge_capture_claim_creation/v1",
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
                return JsonUtils.Deserialize<ChargeCaptureClaimCreationPage>(responseBody)!;
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
