using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.PayerPlanGroups.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Returns all payer plan groups matching filter criteria.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PayerPlanGroups.V1.GetMultiAsync(
    ///     new PayerPlanGroupGetMultiRequest
    ///     {
    ///         PlanGroupName = ["string"],
    ///         PayerUuid = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"],
    ///         PayerId = ["string"],
    ///         PlanType = [SourceOfPaymentCode.SelfPay],
    ///         IsActive = true,
    ///         PayerPlanGroupId = ["d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32"],
    ///         Limit = 1,
    ///         SortBySimilarity = "string",
    ///         Sort = PayerPlanGroupSortField.PlanGroupName,
    ///         SortDirection = Candid.Net.SortDirection.Asc,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<PayerPlanGroupPage> GetMultiAsync(
        PayerPlanGroupGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["plan_group_name"] = request.PlanGroupName;
        _query["payer_uuid"] = request.PayerUuid.Select(_value => _value.ToString()).ToList();
        _query["payer_id"] = request.PayerId;
        _query["plan_type"] = request.PlanType.Select(_value => _value.Stringify()).ToList();
        _query["payer_plan_group_id"] = request
            .PayerPlanGroupId.Select(_value => _value.ToString())
            .ToList();
        if (request.IsActive != null)
        {
            _query["is_active"] = request.IsActive.ToString();
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        if (request.SortBySimilarity != null)
        {
            _query["sort_by_similarity"] = request.SortBySimilarity;
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = "/api/payer-plan-groups/v1",
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
                return JsonUtils.Deserialize<PayerPlanGroupPage>(responseBody)!;
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
    /// Return a plan group with a given ID.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PayerPlanGroups.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<PayerPlanGroup> GetAsync(
        string payerPlanGroupId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/payer-plan-groups/v1/{payerPlanGroupId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PayerPlanGroup>(responseBody)!;
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
    /// Create a payer plan group
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PayerPlanGroups.V1.CreateAsync(
    ///     new MutablePayerPlanGroup
    ///     {
    ///         PlanGroupName = "string",
    ///         PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         PlanType = SourceOfPaymentCode.SelfPay,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<PayerPlanGroup> CreateAsync(
        MutablePayerPlanGroup request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/payer-plan-groups/v1",
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
                return JsonUtils.Deserialize<PayerPlanGroup>(responseBody)!;
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
    /// Update any of the fields on a payer plan group
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PayerPlanGroups.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new MutablePayerPlanGroup
    ///     {
    ///         PlanGroupName = "string",
    ///         PayerUuid = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         PlanType = SourceOfPaymentCode.SelfPay,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<PayerPlanGroup> UpdateAsync(
        string payerPlanGroupId,
        MutablePayerPlanGroup request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Put,
                Path = $"/api/payer-plan-groups/v1/{payerPlanGroupId}",
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
                return JsonUtils.Deserialize<PayerPlanGroup>(responseBody)!;
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
    /// Marks the payer plan group as deactivated
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PayerPlanGroups.V1.DeactivateAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<PayerPlanGroup> DeactivateAsync(
        string payerPlanGroupId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/payer-plan-groups/v1/{payerPlanGroupId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<PayerPlanGroup>(responseBody)!;
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
