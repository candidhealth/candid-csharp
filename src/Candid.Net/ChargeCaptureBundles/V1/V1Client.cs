using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <example><code>
    /// await client.ChargeCaptureBundles.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async System.Threading.Tasks.Task<ChargeCaptureClaimCreation> GetAsync(
        string chargeCaptureClaimCreationId,
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
                        "/api/charge_capture_claim_creation/v1/{0}",
                        ValueConvert.ToPathParameterString(chargeCaptureClaimCreationId)
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
                return JsonUtils.Deserialize<ChargeCaptureClaimCreation>(responseBody)!;
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
    /// await client.ChargeCaptureBundles.V1.GetSummaryAsync();
    /// </code></example>
    public async System.Threading.Tasks.Task<ChargeCaptureClaimCreationSummary> GetSummaryAsync(
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
                    Path = "/api/charge_capture_claim_creation/v1/all/summary",
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
                return JsonUtils.Deserialize<ChargeCaptureClaimCreationSummary>(responseBody)!;
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
    /// await client.ChargeCaptureBundles.V1.ResolveChargeCreationErrorAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ChargeCaptureBundleErrorResolution()
    /// );
    /// </code></example>
    public async System.Threading.Tasks.Task ResolveChargeCreationErrorAsync(
        string chargeCaptureBundleErrorId,
        ChargeCaptureBundleErrorResolution request,
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
                        "/api/charge_capture_claim_creation/v1/error/{0}",
                        ValueConvert.ToPathParameterString(chargeCaptureBundleErrorId)
                    ),
                    Body = request,
                    Options = options,
                },
                cancellationToken
            )
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            return;
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
    /// await client.ChargeCaptureBundles.V1.GetAllAsync(new GetAllChargeCaptureClaimCreationsRequest());
    /// </code></example>
    public async System.Threading.Tasks.Task<ChargeCaptureClaimCreationPage> GetAllAsync(
        GetAllChargeCaptureClaimCreationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["claim_ids"] = request.ClaimIds;
        _query["claim_creation_ids"] = request.ClaimCreationIds;
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
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
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
        if (request.ClaimStatus != null)
        {
            _query["claim_status"] = request.ClaimStatus.Value.Stringify();
        }
        if (request.HasChargeCaptureUpdates != null)
        {
            _query["has_charge_capture_updates"] = JsonUtils.Serialize(
                request.HasChargeCaptureUpdates.Value
            );
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/charge_capture_claim_creation/v1",
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
                return JsonUtils.Deserialize<ChargeCaptureClaimCreationPage>(responseBody)!;
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
