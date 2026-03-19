using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.OrganizationProviders.V3;

public partial class V3Client
{
    private RawClient _client;

    internal V3Client(RawClient client)
    {
        _client = client;
    }

    /// <example><code>
    /// await client.OrganizationProviders.V3.GetAsync("965A563A-0285-4910-9569-E3739C0F6EAB");
    /// </code></example>
    public async global::System.Threading.Tasks.Task<OrganizationProviderV2> GetAsync(
        string organizationProviderId,
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
                        "/api/organization-providers/v3/{0}",
                        ValueConvert.ToPathParameterString(organizationProviderId)
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
                return JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
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
    /// await client.OrganizationProviders.V3.GetMultiAsync(
    ///     new GetAllOrganizationProvidersRequestV2
    ///     {
    ///         Limit = 100,
    ///         SearchTerm = "john",
    ///         Npi = "1234567890",
    ///         IsRendering = true,
    ///         IsBilling = true,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///         Sort = OrganizationProviderSortOptions.ProviderNameAsc,
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<OrganizationProviderPageV2> GetMultiAsync(
        GetAllOrganizationProvidersRequestV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["organization_provider_ids"] = request.OrganizationProviderIds;
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.SearchTerm != null)
        {
            _query["search_term"] = request.SearchTerm;
        }
        if (request.Npi != null)
        {
            _query["npi"] = request.Npi;
        }
        if (request.IsRendering != null)
        {
            _query["is_rendering"] = JsonUtils.Serialize(request.IsRendering.Value);
        }
        if (request.IsBilling != null)
        {
            _query["is_billing"] = JsonUtils.Serialize(request.IsBilling.Value);
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/organization-providers/v3",
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
                return JsonUtils.Deserialize<OrganizationProviderPageV2>(responseBody)!;
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
    /// await client.OrganizationProviders.V3.CreateAsync(
    ///     new OrganizationProviderCreateV2
    ///     {
    ///         Npi = "npi",
    ///         IsRendering = true,
    ///         IsBilling = true,
    ///         ProviderType = ProviderType.Individual,
    ///         LicenseType = LicenseType.Md,
    ///         Qualifications = new List&lt;IdentifierCreate&gt;()
    ///         {
    ///             new IdentifierCreate
    ///             {
    ///                 IdentifierCode = IdentifierCode.Mcr,
    ///                 IdentifierValue = new IdentifierValue(
    ///                     new IdentifierValue.MedicareProviderIdentifier(
    ///                         new MedicareProviderIdentifier
    ///                         {
    ///                             State = State.Aa,
    ///                             ProviderNumber = "provider_number",
    ///                         }
    ///                     )
    ///                 ),
    ///             },
    ///             new IdentifierCreate
    ///             {
    ///                 IdentifierCode = IdentifierCode.Mcr,
    ///                 IdentifierValue = new IdentifierValue(
    ///                     new IdentifierValue.MedicareProviderIdentifier(
    ///                         new MedicareProviderIdentifier
    ///                         {
    ///                             State = State.Aa,
    ///                             ProviderNumber = "provider_number",
    ///                         }
    ///                     )
    ///                 ),
    ///             },
    ///         },
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<OrganizationProviderV2> CreateAsync(
        OrganizationProviderCreateV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Post,
                    Path = "/api/organization-providers/v3",
                    Body = request,
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
                return JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
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
    /// await client.OrganizationProviders.V3.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new OrganizationProviderUpdateV2()
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<OrganizationProviderV2> UpdateAsync(
        string organizationProviderId,
        OrganizationProviderUpdateV2 request,
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
                        "/api/organization-providers/v3/{0}",
                        ValueConvert.ToPathParameterString(organizationProviderId)
                    ),
                    Body = request,
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
                return JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
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
