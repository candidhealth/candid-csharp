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
    public async Task<ChargeCaptureBundle> GetAsync(
        string chargeCaptureBundleId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/charge_capture_bundle/v1/{chargeCaptureBundleId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCaptureBundle>(responseBody)!;
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
    public async Task<ChargeCaptureBundleSummary> GetSummaryAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/charge_capture_bundle/v1/all/summary",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCaptureBundleSummary>(responseBody)!;
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
    /// await client.ChargeCaptureBundles.V1.ResubmitAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<ChargeCaptureBundle> ResubmitAsync(
        string chargeCaptureBundleId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = $"/api/charge_capture_bundle/v1/{chargeCaptureBundleId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ChargeCaptureBundle>(responseBody)!;
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
    ///     new GetAllChargeCaptureBundlesRequest
    ///     {
    ///         Limit = 1,
    ///         Sort = ChargeCaptureBundleSortField.CreatedAt,
    ///         SortDirection = Candid.Net.SortDirection.Asc,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///         PatientExternalId = "string",
    ///         BundleStatus = ChargeCaptureBundleStatus.NotStarted,
    ///         ChargeStatus = ChargeCaptureStatus.Planned,
    ///         ChargeExternalId = "string",
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///         HasChargeCaptureUpdates = true,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ChargeCaptureBundlePage> GetAllAsync(
        GetAllChargeCaptureBundlesRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
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
        if (request.BundleStatus != null)
        {
            _query["bundle_status"] = request.BundleStatus.Value.Stringify();
        }
        if (request.ChargeStatus != null)
        {
            _query["charge_status"] = request.ChargeStatus.Value.Stringify();
        }
        if (request.ChargeExternalId != null)
        {
            _query["charge_external_id"] = request.ChargeExternalId;
        }
        if (request.DateOfService != null)
        {
            _query["date_of_service"] = request.DateOfService.Value.ToString(Constants.DateFormat);
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
                Path = "/api/charge_capture_bundle/v1",
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
                return JsonUtils.Deserialize<ChargeCaptureBundlePage>(responseBody)!;
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
