using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.OrganizationProviders.V3;

public partial class V3Client
{
    private RawClient _client;

    internal V3Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.OrganizationProviders.V3.GetAsync("965A563A-0285-4910-9569-E3739C0F6EAB");
    /// </code>
    /// </example>
    public async Task<OrganizationProviderV2> GetAsync(
        string organizationProviderId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/organization-providers/v3/{organizationProviderId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
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
    /// </code>
    /// </example>
    public async Task<OrganizationProviderPageV2> GetMultiAsync(
        GetAllOrganizationProvidersRequestV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
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
            _query["is_rendering"] = request.IsRendering.ToString();
        }
        if (request.IsBilling != null)
        {
            _query["is_billing"] = request.IsBilling.ToString();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/organization-providers/v3",
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
                return JsonUtils.Deserialize<OrganizationProviderPageV2>(responseBody)!;
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
    /// await client.OrganizationProviders.V3.CreateAsync(
    ///     new OrganizationProviderCreateV2
    ///     {
    ///         Npi = "string",
    ///         IsRendering = true,
    ///         IsBilling = true,
    ///         FirstName = "string",
    ///         LastName = "string",
    ///         OrganizationName = "string",
    ///         ProviderType = ProviderType.Individual,
    ///         TaxId = "string",
    ///         TaxonomyCode = "string",
    ///         LicenseType = LicenseType.Md,
    ///         Addresses = new List&lt;OrganizationProviderAddress&gt;()
    ///         {
    ///             new OrganizationProviderAddress
    ///             {
    ///                 Address = new StreetAddressLongZip
    ///                 {
    ///                     Address1 = "123 Main St",
    ///                     Address2 = "Apt 1",
    ///                     City = "New York",
    ///                     State = State.Ny,
    ///                     ZipCode = "10001",
    ///                     ZipPlusFourCode = "1234",
    ///                 },
    ///                 AddressType = AddressType.Default,
    ///             },
    ///         },
    ///         EmploymentStartDate = new DateOnly(2023, 1, 15),
    ///         EmploymentTerminationDate = new DateOnly(2023, 1, 15),
    ///         Qualifications = new List&lt;IdentifierCreate&gt;()
    ///         {
    ///             new IdentifierCreate
    ///             {
    ///                 Period = new DateRangeOptionalEnd { StartDate = "string" },
    ///                 IdentifierCode = IdentifierCode.Mcr,
    ///                 IdentifierValue = new MedicareProviderIdentifier(),
    ///             },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<OrganizationProviderV2> CreateAsync(
        OrganizationProviderCreateV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/organization-providers/v3",
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
                return JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
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
    /// await client.OrganizationProviders.V3.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new OrganizationProviderUpdateV2
    ///     {
    ///         Npi = "string",
    ///         IsRendering = true,
    ///         IsBilling = true,
    ///         FirstName = "string",
    ///         LastName = "string",
    ///         OrganizationName = "string",
    ///         ProviderType = ProviderType.Individual,
    ///         TaxId = "string",
    ///         TaxonomyCode = "string",
    ///         LicenseType = LicenseType.Md,
    ///         Addresses = new List&lt;OrganizationProviderAddress&gt;()
    ///         {
    ///             new OrganizationProviderAddress
    ///             {
    ///                 Address = new StreetAddressLongZip
    ///                 {
    ///                     Address1 = "123 Main St",
    ///                     Address2 = "Apt 1",
    ///                     City = "New York",
    ///                     State = State.Ny,
    ///                     ZipCode = "10001",
    ///                     ZipPlusFourCode = "1234",
    ///                 },
    ///                 AddressType = AddressType.Default,
    ///             },
    ///         },
    ///         EmploymentStartDate = "string",
    ///         EmploymentTerminationDate = "string",
    ///         Qualifications = new List&lt;object&gt;()
    ///         {
    ///             new IdentifierCreate
    ///             {
    ///                 Period = new DateRangeOptionalEnd { StartDate = "string" },
    ///                 IdentifierCode = IdentifierCode.Mcr,
    ///                 IdentifierValue = new MedicareProviderIdentifier(),
    ///             },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<OrganizationProviderV2> UpdateAsync(
        string organizationProviderId,
        OrganizationProviderUpdateV2 request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/organization-providers/v3/{organizationProviderId}",
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
                return JsonUtils.Deserialize<OrganizationProviderV2>(responseBody)!;
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
