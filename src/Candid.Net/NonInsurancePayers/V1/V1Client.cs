using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

#nullable enable

namespace Candid.Net.NonInsurancePayers.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <example>
    /// <code>
    /// await client.NonInsurancePayers.V1.CreateAsync(
    ///     new CreateNonInsurancePayerRequest
    ///     {
    ///         Name = "string",
    ///         Description = "string",
    ///         Category = "string",
    ///         Address = new StreetAddressShortZip
    ///         {
    ///             Address1 = "123 Main St",
    ///             Address2 = "Apt 1",
    ///             City = "New York",
    ///             State = State.Ny,
    ///             ZipCode = "10001",
    ///             ZipPlusFourCode = "1234",
    ///         },
    ///         ClinicalTrials = new List&lt;MutableClinicalTrial&gt;()
    ///         {
    ///             new MutableClinicalTrial
    ///             {
    ///                 Name = "string",
    ///                 ClinicalTrialNumber = "string",
    ///                 ClinicalTrialPhase = ClinicalTrialPhase.PhaseOne,
    ///             },
    ///         },
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<NonInsurancePayer> CreateAsync(
        CreateNonInsurancePayerRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Post,
                Path = "/api/non-insurance-payers/v1",
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
                return JsonUtils.Deserialize<NonInsurancePayer>(responseBody)!;
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
    /// await client.NonInsurancePayers.V1.ToggleEnablementAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new ToggleNonInsurancePayerEnablementRequest { Enabled = true }
    /// );
    /// </code>
    /// </example>
    public async Task<NonInsurancePayer> ToggleEnablementAsync(
        string nonInsurancePayerId,
        ToggleNonInsurancePayerEnablementRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/non-insurance-payers/v1/{nonInsurancePayerId}/toggle_enablement",
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
                return JsonUtils.Deserialize<NonInsurancePayer>(responseBody)!;
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
    /// await client.NonInsurancePayers.V1.GetMultiAsync(
    ///     new GetMultiNonInsurancePayersRequest
    ///     {
    ///         Name = "string",
    ///         Category = "string",
    ///         Enabled = true,
    ///         Sort = NonInsurancePayerSortField.Name,
    ///         SortDirection = Candid.Net.SortDirection.Asc,
    ///         Limit = 1,
    ///         PageToken = "eyJ0b2tlbiI6IjEiLCJwYWdlX3Rva2VuIjoiMiJ9",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<NonInsurancePayerPage> GetMultiAsync(
        GetMultiNonInsurancePayersRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.Name != null)
        {
            _query["name"] = request.Name;
        }
        if (request.Category != null)
        {
            _query["category"] = request.Category;
        }
        if (request.Enabled != null)
        {
            _query["enabled"] = request.Enabled.ToString();
        }
        if (request.Sort != null)
        {
            _query["sort"] = request.Sort.Value.Stringify();
        }
        if (request.SortDirection != null)
        {
            _query["sort_direction"] = request.SortDirection.Value.Stringify();
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
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
                Path = "/api/non-insurance-payers/v1",
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
                return JsonUtils.Deserialize<NonInsurancePayerPage>(responseBody)!;
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
    /// await client.NonInsurancePayers.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<NonInsurancePayer> GetAsync(
        string nonInsurancePayerId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Get,
                Path = $"/api/non-insurance-payers/v1/{nonInsurancePayerId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<NonInsurancePayer>(responseBody)!;
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
    /// await client.NonInsurancePayers.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new NonInsurancePayerUpdateRequest
    ///     {
    ///         Name = "string",
    ///         Description = "no-properties-union",
    ///         Category = "no-properties-union",
    ///         Address = "no-properties-union",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<NonInsurancePayer> UpdateAsync(
        string nonInsurancePayerId,
        NonInsurancePayerUpdateRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethodExtensions.Patch,
                Path = $"/api/non-insurance-payers/v1/{nonInsurancePayerId}",
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
                return JsonUtils.Deserialize<NonInsurancePayer>(responseBody)!;
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
    /// await client.NonInsurancePayers.V1.DeleteAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task DeleteAsync(
        string nonInsurancePayerId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.CandidApi,
                Method = HttpMethod.Delete,
                Path = $"/api/non-insurance-payers/v1/{nonInsurancePayerId}",
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
