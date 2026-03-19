using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.HealthCareCodeInformation.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<HealthCareCodeInformationGetAllResponse>
    > UpdateAsyncCore(
        string encounterId,
        HealthCareCodeInformationUpdate request,
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
                    Method = HttpMethod.Put,
                    Path = string.Format(
                        "/api/health-care-code-informations/v1/{0}",
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
                var responseData = JsonUtils.Deserialize<HealthCareCodeInformationGetAllResponse>(
                    responseBody
                )!;
                return new WithRawResponse<HealthCareCodeInformationGetAllResponse>()
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
        WithRawResponse<HealthCareCodeInformationGetAllResponse>
    > GetAllForEncounterAsyncCore(
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
                        "/api/health-care-code-informations/v1/{0}",
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
                var responseData = JsonUtils.Deserialize<HealthCareCodeInformationGetAllResponse>(
                    responseBody
                )!;
                return new WithRawResponse<HealthCareCodeInformationGetAllResponse>()
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
    /// await client.HealthCareCodeInformation.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new HealthCareCodeInformationUpdate()
    /// );
    /// </code></example>
    public WithRawResponseTask<HealthCareCodeInformationGetAllResponse> UpdateAsync(
        string encounterId,
        HealthCareCodeInformationUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<HealthCareCodeInformationGetAllResponse>(
            UpdateAsyncCore(encounterId, request, options, cancellationToken)
        );
    }

    /// <example><code>
    /// await client.HealthCareCodeInformation.V1.GetAllForEncounterAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"
    /// );
    /// </code></example>
    public WithRawResponseTask<HealthCareCodeInformationGetAllResponse> GetAllForEncounterAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<HealthCareCodeInformationGetAllResponse>(
            GetAllForEncounterAsyncCore(encounterId, options, cancellationToken)
        );
    }
}
