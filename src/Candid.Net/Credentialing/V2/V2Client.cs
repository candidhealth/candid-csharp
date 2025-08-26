using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.Credentialing.V2;

public partial class V2Client
{
    private RawClient _client;

    internal V2Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.Credentialing.V2.CreateFacilityAsync(
    ///     new FacilityCredentialingSpanCreate
    ///     {
    ///         ServiceFacilityId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<FacilityCredentialingSpan> CreateFacilityAsync(
        FacilityCredentialingSpanCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/provider-credentialing-span/v2/facility",
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
                return JsonUtils.Deserialize<FacilityCredentialingSpan>(responseBody)!;
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
    /// await client.Credentialing.V2.GetFacilityAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<FacilityCredentialingSpan> GetFacilityAsync(
        string facilityCredentialingId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/provider-credentialing-span/v2/facility/{facilityCredentialingId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<FacilityCredentialingSpan>(responseBody)!;
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
    /// await client.Credentialing.V2.GetAllFacilitiesAsync(new GetAllFacilityCredentialingSpansRequest());
    /// </code>
    /// </example>
    public async Task<FacilityCredentialingSpanPage> GetAllFacilitiesAsync(
        GetAllFacilityCredentialingSpansRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.PayerUuid != null)
        {
            _query["payer_uuid"] = request.PayerUuid.ToString();
        }
        if (request.ContractingProviderId != null)
        {
            _query["contracting_provider_id"] = request.ContractingProviderId.ToString();
        }
        if (request.ServiceFacilityId != null)
        {
            _query["service_facility_id"] = request.ServiceFacilityId.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/provider-credentialing-span/v2/facility",
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
                return JsonUtils.Deserialize<FacilityCredentialingSpanPage>(responseBody)!;
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
    /// Soft deletes a credentialing span rate from the system.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Credentialing.V2.DeleteFacilityAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteFacilityAsync(
        string facilityCredentialingId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/provider-credentialing-span/v2/facility/{facilityCredentialingId}",
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
    /// await client.Credentialing.V2.UpdateFacilityAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new FacilityCredentialingSpanUpdate
    ///     {
    ///         ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<FacilityCredentialingSpan> UpdateFacilityAsync(
        string facilityCredentialingId,
        FacilityCredentialingSpanUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/provider-credentialing-span/v2/facility/{facilityCredentialingId}",
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
                return JsonUtils.Deserialize<FacilityCredentialingSpan>(responseBody)!;
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
    /// await client.Credentialing.V2.CreateAsync(
    ///     new ProviderCredentialingSpanCreate
    ///     {
    ///         RenderingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         Regions = new RegionStates
    ///         {
    ///             States = new List&lt;State&gt;() { State.Aa, State.Aa },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<ProviderCredentialingSpan> CreateAsync(
        ProviderCredentialingSpanCreate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/provider-credentialing-span/v2",
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
                return JsonUtils.Deserialize<ProviderCredentialingSpan>(responseBody)!;
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
    /// await client.Credentialing.V2.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<ProviderCredentialingSpan> GetAsync(
        string providerCredentialingId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/provider-credentialing-span/v2/{providerCredentialingId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<ProviderCredentialingSpan>(responseBody)!;
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
    /// await client.Credentialing.V2.GetAllAsync(new GetAllProviderCredentialingSpansRequest());
    /// </code>
    /// </example>
    public async Task<ProviderCredentialingSpanPage> GetAllAsync(
        GetAllProviderCredentialingSpansRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.PayerUuid != null)
        {
            _query["payer_uuid"] = request.PayerUuid.ToString();
        }
        if (request.ProviderId != null)
        {
            _query["provider_id"] = request.ProviderId.ToString();
        }
        if (request.AsRenderingProvider != null)
        {
            _query["as_rendering_provider"] = request.AsRenderingProvider.ToString();
        }
        if (request.AsContractingProvider != null)
        {
            _query["as_contracting_provider"] = request.AsContractingProvider.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/provider-credentialing-span/v2",
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
                return JsonUtils.Deserialize<ProviderCredentialingSpanPage>(responseBody)!;
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
    /// Soft deletes a credentialing span rate from the system.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.Credentialing.V2.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string providerCredentialingId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/provider-credentialing-span/v2/{providerCredentialingId}",
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
    /// await client.Credentialing.V2.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ProviderCredentialingSpanUpdate()
    /// );
    /// </code>
    /// </example>
    public async Task<ProviderCredentialingSpan> UpdateAsync(
        string providerCredentialingId,
        ProviderCredentialingSpanUpdate request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/provider-credentialing-span/v2/{providerCredentialingId}",
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
                return JsonUtils.Deserialize<ProviderCredentialingSpan>(responseBody)!;
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
