using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;
using Candid.Net.PreEncounter.EligibilityChecks.V1;

#nullable enable

namespace Candid.Net.PreEncounter.Coverages.V1;

public partial class V1Client
{
    private RawClient _client;

    internal V1Client(RawClient client)
    {
        _client = client;
    }

    /// <summary>
    /// Creates a new Coverage. A Coverage provides the high-level identifiers and descriptors of a specific insurance plan for a specific individual - typically the information you can find on an insurance card. Additionally a coverage will include detailed benefits information covered by the specific plan for the individual.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.CreateAsync(
    ///     new MutableCoverage
    ///     {
    ///         Status = CoverageStatus.Active,
    ///         Subscriber = new Candid.Net.PreEncounter.Coverages.V1.Subscriber
    ///         {
    ///             Name = new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///             DateOfBirth = new DateOnly(2023, 1, 15),
    ///             BiologicalSex = Sex.Female,
    ///         },
    ///         Relationship = Relationship.Self,
    ///         Patient = "patient",
    ///         InsurancePlan = new InsurancePlan
    ///         {
    ///             MemberId = "member_id",
    ///             PayerId = "payer_id",
    ///             PayerName = "payer_name",
    ///         },
    ///         Verified = true,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Coverage> CreateAsync(
        MutableCoverage request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = "/coverages/v1",
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
                return JsonUtils.Deserialize<Coverage>(responseBody)!;
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
    /// Updates a Coverage. The path must contain the next version number to prevent race conditions. For example, if the current version of the coverage is n, you will need to send a request to this endpoint with `/{id}/n+1` to update the coverage. Updating historic versions is not supported.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     "version",
    ///     new MutableCoverage
    ///     {
    ///         Status = CoverageStatus.Active,
    ///         Subscriber = new Candid.Net.PreEncounter.Coverages.V1.Subscriber
    ///         {
    ///             Name = new HumanName
    ///             {
    ///                 Family = "family",
    ///                 Given = new List&lt;string&gt;() { "given", "given" },
    ///                 Use = NameUse.Usual,
    ///             },
    ///             DateOfBirth = new DateOnly(2023, 1, 15),
    ///             BiologicalSex = Sex.Female,
    ///         },
    ///         Relationship = Relationship.Self,
    ///         Patient = "patient",
    ///         InsurancePlan = new InsurancePlan
    ///         {
    ///             MemberId = "member_id",
    ///             PayerId = "payer_id",
    ///             PayerName = "payer_name",
    ///         },
    ///         Verified = true,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<Coverage> UpdateAsync(
        string id,
        string version,
        MutableCoverage request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Put,
                Path = $"/coverages/v1/{id}/{version}",
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
                return JsonUtils.Deserialize<Coverage>(responseBody)!;
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
    /// Returns a page of Coverages based on the search criteria.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.GetMultiPaginatedAsync(
    ///     new CoverageGetMultiPaginatedRequest()
    /// );
    /// </code>
    /// </example>
    public async Task<CoveragesPage> GetMultiPaginatedAsync(
        CoverageGetMultiPaginatedRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.PatientId != null)
        {
            _query["patient_id"] = request.PatientId;
        }
        if (request.PayerPlanGroupId != null)
        {
            _query["payer_plan_group_id"] = request.PayerPlanGroupId;
        }
        if (request.PageToken != null)
        {
            _query["page_token"] = request.PageToken;
        }
        if (request.Limit != null)
        {
            _query["limit"] = request.Limit.ToString();
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/coverages/v1/get-multi-paginated",
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
                return JsonUtils.Deserialize<CoveragesPage>(responseBody)!;
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
    /// gets a specific Coverage
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.GetAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<Coverage> GetAsync(
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
                Path = $"/coverages/v1/{id}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<Coverage>(responseBody)!;
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
    /// Gets a coverage along with it's full history.  The return list is ordered by version ascending.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.GetHistoryAsync("d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32");
    /// </code>
    /// </example>
    public async Task<IEnumerable<Coverage>> GetHistoryAsync(
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
                Path = $"/coverages/v1/{id}/history",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<IEnumerable<Coverage>>(responseBody)!;
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
    /// Returns a list of Coverages based on the search criteria.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.GetMultiAsync(new CoverageGetMultiRequest());
    /// </code>
    /// </example>
    public async Task<IEnumerable<Coverage>> GetMultiAsync(
        CoverageGetMultiRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        if (request.PatientId != null)
        {
            _query["patient_id"] = request.PatientId;
        }
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/coverages/v1",
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
                return JsonUtils.Deserialize<IEnumerable<Coverage>>(responseBody)!;
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
    /// Scans up to 100 coverage updates.  The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.ScanAsync(
    ///     new CoverageScanRequest { Since = new DateTime(2024, 01, 15, 09, 30, 00, 000) }
    /// );
    /// </code>
    /// </example>
    public async Task<IEnumerable<Coverage>> ScanAsync(
        CoverageScanRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var _query = new Dictionary<string, object>();
        _query["since"] = request.Since.ToString(Constants.DateTimeFormat);
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = "/coverages/v1/updates/scan",
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
                return JsonUtils.Deserialize<IEnumerable<Coverage>>(responseBody)!;
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
    /// Finds all coverages associated with the given ppg_id and updates the ppg_fields for each coverage.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.BatchUpdatePpgAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new PayerPlanGroupFields
    ///     {
    ///         PayerPlanGroupId = "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///         PayerId = "payer_id",
    ///         PayerName = "payer_name",
    ///         PlanType = Candid.Net.PreEncounter.Coverages.V1.NetworkType.SelfPay,
    ///     }
    /// );
    /// </code>
    /// </example>
    public async System.Threading.Tasks.Task BatchUpdatePpgAsync(
        string ppgId,
        PayerPlanGroupFields request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = $"/coverages/v1/batch-update-ppg/{ppgId}",
                Body = request,
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
    /// Initiates an eligibility check. Returns the metadata of the check if successfully initiated.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.CheckEligibilityAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     new CheckEligibilityRequest
    ///     {
    ///         ServiceCode = ServiceTypeCode.MedicalCare,
    ///         DateOfService = new DateOnly(2023, 1, 15),
    ///         Npi = "npi",
    ///     }
    /// );
    /// </code>
    /// </example>
    public async Task<EligibilityCheckMetadata> CheckEligibilityAsync(
        string id,
        CheckEligibilityRequest request,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Post,
                Path = $"/coverages/v1/{id}/eligibility",
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
                return JsonUtils.Deserialize<EligibilityCheckMetadata>(responseBody)!;
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
    /// Gets the eligibility of a patient for a specific coverage if successful.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.GetEligibilityAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     "check_id"
    /// );
    /// </code>
    /// </example>
    public async Task<CoverageEligibilityCheckResponse> GetEligibilityAsync(
        string id,
        string checkId,
        RequestOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        var response = await _client.MakeRequestAsync(
            new RawClient.JsonApiRequest
            {
                BaseUrl = _client.Options.Environment.PreEncounter,
                Method = HttpMethod.Get,
                Path = $"/coverages/v1/{id}/eligibility/{checkId}",
                Options = options,
            },
            cancellationToken
        );
        var responseBody = await response.Raw.Content.ReadAsStringAsync();
        if (response.StatusCode is >= 200 and < 400)
        {
            try
            {
                return JsonUtils.Deserialize<CoverageEligibilityCheckResponse>(responseBody)!;
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
