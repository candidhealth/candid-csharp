using System.Text.Json;
using Candid.Net;
using Candid.Net.Core;

namespace Candid.Net.ChargeCaptureBundles.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<ChargeCaptureClaimCreation>
    > GetAsyncCore(
        string chargeCaptureClaimCreationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                        "/api/charge_capture_claim_creation/v1/{0}",
                        ValueConvert.ToPathParameterString(chargeCaptureClaimCreationId)
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
                var responseData = JsonUtils.Deserialize<ChargeCaptureClaimCreation>(responseBody)!;
                return new WithRawResponse<ChargeCaptureClaimCreation>()
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
        WithRawResponse<ChargeCaptureClaimCreationSummary>
    > GetSummaryAsyncCore(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Path = "/api/charge_capture_claim_creation/v1/all/summary",
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
                var responseData = JsonUtils.Deserialize<ChargeCaptureClaimCreationSummary>(
                    responseBody
                )!;
                return new WithRawResponse<ChargeCaptureClaimCreationSummary>()
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
        WithRawResponse<ChargeCaptureClaimCreationPage>
    > GetAllAsyncCore(
        GetAllChargeCaptureClaimCreationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _queryString = new Candid.Net.Core.QueryStringBuilder.Builder(capacity: 25)
            .Add("limit", request.Limit)
            .Add("sort", request.Sort)
            .Add("sort_direction", request.SortDirection)
            .Add("page_token", request.PageToken)
            .Add("patient_external_id", request.PatientExternalId)
            .Add("claim_creation_status", request.ClaimCreationStatus)
            .Add("charge_status", request.ChargeStatus)
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
            .Add("claim_status", request.ClaimStatus)
            .Add("claim_creation_category", request.ClaimCreationCategory)
            .Add("tags", request.Tags)
            .Add("primary_payer_names", request.PrimaryPayerNames)
            .Add("patient_names", request.PatientNames)
            .Add("has_charge_capture_updates", request.HasChargeCaptureUpdates)
            .MergeAdditional(options?.AdditionalQueryParameters)
            .Build();
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                    Path = "/api/charge_capture_claim_creation/v1",
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
                var responseData = JsonUtils.Deserialize<ChargeCaptureClaimCreationPage>(
                    responseBody
                )!;
                return new WithRawResponse<ChargeCaptureClaimCreationPage>()
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
    /// await client.ChargeCaptureBundles.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<ChargeCaptureClaimCreation> GetAsync(
        string chargeCaptureClaimCreationId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ChargeCaptureClaimCreation>(
            GetAsyncCore(chargeCaptureClaimCreationId, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.ChargeCaptureBundles.V1.GetSummaryAsync();
    /// </code></example>
    public WithRawResponseTask<ChargeCaptureClaimCreationSummary> GetSummaryAsync(
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ChargeCaptureClaimCreationSummary>(
            GetSummaryAsyncCore(options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.ChargeCaptureBundles.V1.ResolveChargeCreationErrorAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ChargeCaptureBundleErrorResolution()
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task ResolveChargeCreationErrorAsync(
        string chargeCaptureBundleErrorId,
        ChargeCaptureBundleErrorResolution request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _headers = await new Candid.Net.Core.HeadersBuilder.Builder()
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
                        "/api/charge_capture_claim_creation/v1/error/{0}",
                        ValueConvert.ToPathParameterString(chargeCaptureBundleErrorId)
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
            return;
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
    /// await client.ChargeCaptureBundles.V1.GetAllAsync(new GetAllChargeCaptureClaimCreationsRequest());
    /// </code></example>
    public WithRawResponseTask<ChargeCaptureClaimCreationPage> GetAllAsync(
        GetAllChargeCaptureClaimCreationsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<ChargeCaptureClaimCreationPage>(
            GetAllAsyncCore(request, options, cancellationToken)
        );
    }
}
