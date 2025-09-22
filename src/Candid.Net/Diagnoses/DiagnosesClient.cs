using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Diagnoses;

public partial class DiagnosesClient
{
    private RawClient _client;

    internal DiagnosesClient(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a new diagnosis for an encounter
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Diagnoses.CreateAsync(
    ///     new StandaloneDiagnosisCreate
    ///     {
    ///         CodeType = DiagnosisTypeCode.Abf,
    ///         Code = "code",
    ///         EncounterId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Diagnosis> CreateAsync(
        StandaloneDiagnosisCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/diagnoses/v2",
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
                return JsonUtils.Deserialize<Diagnosis>(responseBody)!;
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
    /// Updates the diagnosis record matching the provided `diagnosis_id`
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Diagnoses.UpdateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32", new DiagnosisUpdate());
    /// </code>
    /// </example>
    public async Task<Diagnosis> UpdateAsync(
        string diagnosisId,
        DiagnosisUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/diagnoses/v2/{diagnosisId}",
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
                return JsonUtils.Deserialize<Diagnosis>(responseBody)!;
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
    /// Deletes the diagnosis record associated with the provided `diagnosis_id`
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Diagnoses.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string diagnosisId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/diagnoses/v2/{diagnosisId}",
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
}
