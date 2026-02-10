using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.EncounterAttachments.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <example><code>
    /// await client.EncounterAttachments.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async global::System.Threading.Tasks.Task<IEnumerable<EncounterAttachment>> GetAsync(
        string encounterId,
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
                        "/api/encounter-attachments/v1/{0}",
                        ValueConvert.ToPathParameterString(encounterId)
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
                return JsonUtils.Deserialize<IEnumerable<EncounterAttachment>>(responseBody)!;
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

    /// <summary>
    /// Uploads a file to the encounter. The file will be stored in the
    /// encounter's attachments. Deprecated: Use create-v2 instead.
    /// </summary>
    public async global::System.Threading.Tasks.Task<string> CreateAsync(
        string encounterId,
        CreateAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var multipartFormRequest_ = new MultipartFormRequest
        {
            BaseUrl = _client.Options.Environment.CandidApi,
            Method = HttpMethod.Put,
            Path = string.Format(
                "/api/encounter-attachments/v1/{0}",
                ValueConvert.ToPathParameterString(encounterId)
            ),
            Options = options,
        };
        multipartFormRequest_.AddFileParameterPart("attachment_file", request.AttachmentFile);
        multipartFormRequest_.AddJsonPart("attachment_type", request.AttachmentType);
        var response = await _client
            .SendRequestAsync(multipartFormRequest_, cancellationToken)
            .ConfigureAwait(false);
        if (response.StatusCode is >= 200 and < 400)
        {
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<string>(responseBody)!;
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

    /// <summary>
    /// Uploads a file to the encounter. The file will be stored in the
    /// encounter's attachments.
    /// </summary>
    public async global::System.Threading.Tasks.Task<string> CreateWithDescriptionAsync(
        string encounterId,
        CreateAttachmentV2Request request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var multipartFormRequest_ = new MultipartFormRequest
        {
            BaseUrl = _client.Options.Environment.CandidApi,
            Method = HttpMethod.Put,
            Path = string.Format(
                "/api/encounter-attachments/v1/{0}/v2",
                ValueConvert.ToPathParameterString(encounterId)
            ),
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
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<string>(responseBody)!;
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

    /// <summary>
    /// Uploads a file using an external identifier. For Charge Capture, the file will be associated with the Encounter at Encounter creation time.
    ///
    /// Note: Attachments created via this endpoint are not searchable via the get endpoint until they are associated with an encounter.
    /// </summary>
    public async global::System.Threading.Tasks.Task<string> CreateWithChargeCaptureExternalIdAsync(
        CreateExternalAttachmentRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var multipartFormRequest_ = new MultipartFormRequest
        {
            BaseUrl = _client.Options.Environment.CandidApi,
            Method = HttpMethod.Post,
            Path = "/api/encounter-attachments/v1/create-from-charge-capture-external-id",
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
            var responseBody = await response.Raw.Content.ReadAsStringAsync();
            try
            {
                return JsonUtils.Deserialize<string>(responseBody)!;
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
}
