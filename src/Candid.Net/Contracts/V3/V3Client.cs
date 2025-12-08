using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

namespace Candid.Net.Contracts.V3;

public partial class V3Client
{
    private RawClient _client;

    internal V3Client(RawClient client)
    {
        _client = client;
    }

    /// <example><code>
    /// await client.Contracts.V3.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async global::System.Threading.Tasks.Task<ContractWithProvidersUnion> GetAsync(
        string contractId,
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
                        "/api/contracts/v3/{0}",
                        ValueConvert.ToPathParameterString(contractId)
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
                return JsonUtils.Deserialize<ContractWithProvidersUnion>(responseBody)!;
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
    /// await client.Contracts.V3.GetMultiAsync(
    ///     new global::Candid.Net.Contracts.V3.GetMultiContractsRequest()
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<ContractsPage> GetMultiAsync(
        GetMultiContractsRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["rendering_provider_ids"] = request.RenderingProviderIds;
        _query["payer_names"] = request.PayerNames;
        _query["states"] = request.States.Select(_value => _value.Stringify()).ToList();
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.Value.ToString();
        }
        if (request.Type != null)
        {
            _query["type"] = request.Type.Value.Stringify();
        }
        if (request.ContractingProviderId != null)
        {
            _query["contracting_provider_id"] = request.ContractingProviderId;
        }
        if (request.ContractStatus != null)
        {
            _query["contract_status"] = request.ContractStatus.Value.Stringify();
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        var response = await _client
            .SendRequestAsync(
                new JsonRequest
                {
                    BaseUrl = _client.Options.Environment.CandidApi,
                    Method = HttpMethod.Get,
                    Path = "/api/contracts/v3",
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
                return JsonUtils.Deserialize<ContractsPage>(responseBody)!;
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
    /// Creates a new contract within the user's current organization
    /// </summary>
    /// <example><code>
    /// await client.Contracts.V3.CreateAsync(
    ///     new ContractCreateUnion(
    ///         new ContractCreateUnion.Professional(
    ///             new ProfessionalContractCreate
    ///             {
    ///                 RenderingProviderIds = new HashSet&lt;string&gt;()
    ///                 {
    ///                     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 },
    ///                 ContractType = ContractType.Professional,
    ///                 ContractingProviderId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///                 EffectiveDate = "effective_date",
    ///                 Regions = new Regions(
    ///                     new Regions.States(
    ///                         new RegionStates
    ///                         {
    ///                             States = new List&lt;State&gt;() { State.Aa, State.Aa },
    ///                         }
    ///                     )
    ///                 ),
    ///                 CommercialInsuranceTypes = new InsuranceTypes(new InsuranceTypes.AllApply()),
    ///                 MedicareInsuranceTypes = new InsuranceTypes(new InsuranceTypes.AllApply()),
    ///                 MedicaidInsuranceTypes = new InsuranceTypes(new InsuranceTypes.AllApply()),
    ///             }
    ///         )
    ///     )
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<ContractWithProvidersUnion> CreateAsync(
        ContractCreateUnion request,
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
                    Path = "/api/contracts/v3",
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
                return JsonUtils.Deserialize<ContractWithProvidersUnion>(responseBody)!;
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
    /// await client.Contracts.V3.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code></example>
    public async global::System.Threading.Tasks.Task DeleteAsync(
        string contractId,
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
                        "/api/contracts/v3/{0}",
                        ValueConvert.ToPathParameterString(contractId)
                    ),
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

    /// <example><code>
    /// await client.Contracts.V3.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ContractUpdateUnion(new ContractUpdateUnion.Professional(new ProfessionalContractUpdate()))
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<ContractWithProvidersUnion> UpdateAsync(
        string contractId,
        ContractUpdateUnion request,
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
                        "/api/contracts/v3/{0}",
                        ValueConvert.ToPathParameterString(contractId)
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
                return JsonUtils.Deserialize<ContractWithProvidersUnion>(responseBody)!;
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
    /// await client.Contracts.V3.CreateContractServiceFacilityAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ContractServiceFacilityCreate
    ///     {
    ///         ServiceFacilityId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         ProviderIds = new HashSet&lt;string&gt;() { "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32" },
    ///     }
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<ContractServiceFacility> CreateContractServiceFacilityAsync(
        string contractId,
        ContractServiceFacilityCreate request,
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
                    Path = string.Format(
                        "/api/contracts/v3/{0}/service-facilities",
                        ValueConvert.ToPathParameterString(contractId)
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
                return JsonUtils.Deserialize<ContractServiceFacility>(responseBody)!;
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
    /// await client.Contracts.V3.UpdateContractServiceFacilityAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ContractServiceFacilityUpdate()
    /// );
    /// </code></example>
    public async global::System.Threading.Tasks.Task<ContractServiceFacility> UpdateContractServiceFacilityAsync(
        string contractId,
        string contractServiceFacilityId,
        ContractServiceFacilityUpdate request,
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
                        "/api/contracts/v3/{0}/service-facilities/{1}",
                        ValueConvert.ToPathParameterString(contractId),
                        ValueConvert.ToPathParameterString(contractServiceFacilityId)
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
                return JsonUtils.Deserialize<ContractServiceFacility>(responseBody)!;
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
