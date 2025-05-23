using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PreEncounter.Images.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Adds an image.  VersionConflictError is returned if a front or back of this coverage already exists.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Images.V1.CreateAsync(
    ///     new MutableImage
    ///     {
    ///         FileName = "file_name",
    ///         DisplayName = "display_name",
    ///         FileType = "file_type",
    ///         Status = ImageStatus.Pending,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Image> CreateAsync(
        MutableImage request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/images/v1",
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
                return JsonUtils.Deserialize<Image>(responseBody)!;
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
    /// Gets an image by imageId.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Images.V1.GetAsync("id");
    /// </code>
    /// </example>
    public async Task<Image> GetAsync(
        string id,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/images/v1/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Image>(responseBody)!;
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
    /// Updates an Image.  The path must contain the most recent version to prevent races.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Images.V1.UpdateAsync(
    ///     "id",
    ///     "version",
    ///     new MutableImage
    ///     {
    ///         FileName = "file_name",
    ///         DisplayName = "display_name",
    ///         FileType = "file_type",
    ///         Status = ImageStatus.Pending,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Image> UpdateAsync(
        string id,
        string version,
        MutableImage request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Put,
                Path = $"/images/v1/{id}/{version}",
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
                return JsonUtils.Deserialize<Image>(responseBody)!;
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
    /// Sets an Image as deactivated.  The path must contain the most recent version to prevent races.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Images.V1.DeactivateAsync("id", "version");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeactivateAsync(
        string id,
        string version,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Delete,
                Path = $"/images/v1/{id}/{version}",
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

    /// <summary>
    /// Searches for images that match the query parameters.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Images.V1.GetMultiAsync(new ImageGetMultiRequest());
    /// </code>
    /// </example>
    public async Task<IEnumerable<Image>> GetMultiAsync(
        ImageGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.PatientId != null)
        {
            _query["patient_id"] = request.PatientId;
        }
        if (request.CoverageId != null)
        {
            _query["coverage_id"] = request.CoverageId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/images/v1",
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
                return JsonUtils.Deserialize<IEnumerable<Image>>(responseBody)!;
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
