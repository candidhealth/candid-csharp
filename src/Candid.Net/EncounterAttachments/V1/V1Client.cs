using System.Text.Json;
using global::Candid.Net;
using global::Candid.Net.Core;

namespace Candid.Net.EncounterAttachments.V1;

public partial class V1Client : IV1Client
{
    private readonly RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    private async global::System.Threading.Tasks.Task<
        WithRawResponse<IEnumerable<EncounterAttachment>>
    > GetAsyncCore(
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
                        "/api/encounter-attachments/v1/{0}",
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
                var responseData = JsonUtils.Deserialize<IEnumerable<EncounterAttachment>>(
                    responseBody
                )!;
                return new WithRawResponse<IEnumerable<EncounterAttachment>>()
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

    private async global::System.Threading.Tasks.Task<WithRawResponse<string>> CreateAsyncCore(
        string encounterId,
        CreateAttachmentRequest request,
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
        var multipartFormRequest_ = new MultipartFormRequest
        {
            BaseUrl = _client.Options.Environment.CandidApi,
            Method = HttpMethod.Put,
            Path = string.Format(
                "/api/encounter-attachments/v1/{0}",
                ValueConvert.ToPathParameterString(encounterId)
            ),
            Headers = _headers,
            Options = options,
        };
        multipartFormRequest_.AddFileParameterPart("attachment_file", request.AttachmentFile);
        multipartFormRequest_.AddJsonPart("attachment_type", request.AttachmentType);
        var response = await _client
            .SendRequestAsync(multipartFormRequest_, cancellationToken)
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<string>(responseBody)!;
                return new WithRawResponse<string>()
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
        WithRawResponse<string>
    > CreateWithDescriptionAsyncCore(
        string encounterId,
        CreateAttachmentV2Request request,
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
        var multipartFormRequest_ = new MultipartFormRequest
        {
            BaseUrl = _client.Options.Environment.CandidApi,
            Method = HttpMethod.Put,
            Path = string.Format(
                "/api/encounter-attachments/v1/{0}/v2",
                ValueConvert.ToPathParameterString(encounterId)
            ),
            Headers = _headers,
            Options = options,
        };
        multipartFormRequest_.AddFileParameterPart("attachment_file", request.AttachmentFile);
        multipartFormRequest_.AddJsonPart("attachment_type", request.AttachmentType);
        multipartFormRequest_.AddStringPart("description", request.Description);
        var response = await _client
            .SendRequestAsync(multipartFormRequest_, cancellationToken)
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<string>(responseBody)!;
                return new WithRawResponse<string>()
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
        WithRawResponse<string>
    > CreateWithChargeCaptureExternalIdAsyncCore(
        CreateExternalAttachmentRequest request,
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
        var multipartFormRequest_ = new MultipartFormRequest
        {
            BaseUrl = _client.Options.Environment.CandidApi,
            Method = HttpMethod.Post,
            Path = "/api/encounter-attachments/v1/create-from-charge-capture-external-id",
            Headers = _headers,
            Options = options,
        };
        multipartFormRequest_.AddStringPart(
            "charge_capture_external_id",
            request.ChargeCaptureExternalId
        );
        multipartFormRequest_.AddFileParameterPart("attachment_file", request.AttachmentFile);
        multipartFormRequest_.AddJsonPart("attachment_type", request.AttachmentType);
        multipartFormRequest_.AddStringPart("description", request.Description);
        var response = await _client
            .SendRequestAsync(multipartFormRequest_, cancellationToken)
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response
                .Raw.Content.ReadAsStringAsync(cancellationToken)
                .ConfigureAwait(false);
            try
            {
                var responseData = JsonUtils.Deserialize<string>(responseBody)!;
                return new WithRawResponse<string>()
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
        WithRawResponse<IEnumerable<ChargeCaptureAttachment>>
    > GetByChargeCaptureExternalIdAsyncCore(
        string chargeCaptureExternalId,
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
                        "/api/encounter-attachments/v1/by-charge-capture-external-id/{0}",
                        ValueConvert.ToPathParameterString(chargeCaptureExternalId)
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
                var responseData = JsonUtils.Deserialize<IEnumerable<ChargeCaptureAttachment>>(
                    responseBody
                )!;
                return new WithRawResponse<IEnumerable<ChargeCaptureAttachment>>()
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
    /// await client.EncounterAttachments.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public WithRawResponseTask<IEnumerable<EncounterAttachment>> GetAsync(
        string encounterId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<EncounterAttachment>>(
            GetAsyncCore(encounterId, options, cancellationToken)
        );
    }

    /// <summary>
    /// Uploads a file to the encounter. The file will be stored in the
    /// encounter's attachments. Deprecated: Use create-v2 instead.
    /// </summary>
    public WithRawResponseTask<string> CreateAsync(
        string encounterId,
        CreateAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<string>(
            CreateAsyncCore(encounterId, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Uploads a file to the encounter. The file will be stored in the
    /// encounter's attachments.
    /// </summary>
    public WithRawResponseTask<string> CreateWithDescriptionAsync(
        string encounterId,
        CreateAttachmentV2Request request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<string>(
            CreateWithDescriptionAsyncCore(encounterId, request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Uploads a file using an external identifier. For Charge Capture, the file will be associated with the Encounter at Encounter creation time.
    ///
    /// Note: Attachments created via this endpoint are not searchable via the get endpoint until they are associated with an encounter.
    /// </summary>
    public WithRawResponseTask<string> CreateWithChargeCaptureExternalIdAsync(
        CreateExternalAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<string>(
            CreateWithChargeCaptureExternalIdAsyncCore(request, options, cancellationToken)
        );
    }

    /// <summary>
    /// Returns all attachments associated with the given charge capture external ID.
    /// </summary>
    /// <example><code>
    /// await client.EncounterAttachments.V1.GetByChargeCaptureExternalIdAsync(
    ///     "charge_capture_external_id"
    /// );
    /// </code></example>
    public WithRawResponseTask<
        IEnumerable<ChargeCaptureAttachment>
    > GetByChargeCaptureExternalIdAsync(
        string chargeCaptureExternalId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        return new WithRawResponseTask<IEnumerable<ChargeCaptureAttachment>>(
            GetByChargeCaptureExternalIdAsyncCore(
                chargeCaptureExternalId,
                options,
                cancellationToken
            )
        );
    }

    /// <summary>
    /// Deletes an attachment associated with the given charge capture external ID.
    /// </summary>
    /// <example><code>
    /// await client.EncounterAttachments.V1.DeleteByChargeCaptureExternalIdAsync(
    ///     "charge_capture_external_id",
    ///     new DeleteExternalAttachmentRequest { AttachmentId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteByChargeCaptureExternalIdAsync(
        string chargeCaptureExternalId,
        DeleteExternalAttachmentRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "/api/encounter-attachments/v1/by-charge-capture-external-id/{0}",
                        ValueConvert.ToPathParameterString(chargeCaptureExternalId)
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
    /// await client.EncounterAttachments.V1.DeleteAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new DeleteAttachmentRequest { AttachmentId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteAsync(
        string encounterId,
        DeleteAttachmentRequest request,
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
                    Method = HttpMethod.Delete,
                    Path = string.Format(
                        "/api/encounter-attachments/v1/{0}",
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
}
