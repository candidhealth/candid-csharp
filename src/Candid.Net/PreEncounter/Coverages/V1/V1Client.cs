using System.Net.Http;
using System.Text.Json;
using System.Threading;
using Candid.Net.Core;

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
    ///                 Family = "string",
    ///                 Given = new List&lt;string&gt;() { "string" },
    ///                 Use = NameUse.Usual,
    ///                 Period = new Period(),
    ///             },
    ///             DateOfBirth = new DateOnly(2023, 1, 15),
    ///             BiologicalSex = Sex.Female,
    ///             Address = new Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "string" },
    ///                 City = "string",
    ///                 State = "string",
    ///                 PostalCode = "string",
    ///                 Country = "string",
    ///                 Period = new Period(),
    ///             },
    ///         },
    ///         Relationship = Relationship.Self,
    ///         Patient = "string",
    ///         InsurancePlan = new InsurancePlan
    ///         {
    ///             MemberId = "string",
    ///             PayerId = "string",
    ///             PayerName = "string",
    ///             AdditionalPayerInformation = new AdditionalPayerInformation
    ///             {
    ///                 AvailityEligibilityId = "string",
    ///                 AvailityPayerId = "string",
    ///                 AvailityPayerName = "string",
    ///                 AvailityRemittancePayerId = "string",
    ///             },
    ///             GroupNumber = "string",
    ///             Name = "string",
    ///             PlanType = Candid.Net.PreEncounter.Coverages.V1.NetworkType.SelfPay,
    ///             Type = Candid.Net.PreEncounter.Coverages.V1.InsuranceTypeCode.C01,
    ///             Period = new Period(),
    ///             InsuranceCardImageLocator = "string",
    ///         },
    ///         Verified = true,
    ///         EligibilityChecks = new List&lt;EligibilityCheckMetadata&gt;()
    ///         {
    ///             new EligibilityCheckMetadata
    ///             {
    ///                 CheckId = "string",
    ///                 ServiceCode = ServiceTypeCode.MedicalCare,
    ///                 Status = EligibilityCheckStatus.Completed,
    ///                 InitiatedBy = "string",
    ///                 InitiatedAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///             },
    ///         },
    ///         LatestEligibilityCheck = new LatestEligibilityCheck
    ///         {
    ///             CheckId = "string",
    ///             Status = EligibilityStatus.Active,
    ///             InitiatedAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         },
    ///         Benefits = new CoverageBenefits(),
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
    /// Updates a Coverage. The path must contain the most recent version to prevent race conditions. Updating historic versions is not supported.
    /// </summary>
    /// <example>
    /// <code>
    /// await client.PreEncounter.Coverages.V1.UpdateAsync(
    ///     "d5e9c84f-c2b2-4bf4-b4b0-7ffd7a9ffc32",
    ///     "string",
    ///     new MutableCoverage
    ///     {
    ///         Status = CoverageStatus.Active,
    ///         Subscriber = new Candid.Net.PreEncounter.Coverages.V1.Subscriber
    ///         {
    ///             Name = new HumanName
    ///             {
    ///                 Family = "string",
    ///                 Given = new List&lt;string&gt;() { "string" },
    ///                 Use = NameUse.Usual,
    ///                 Period = new Period(),
    ///             },
    ///             DateOfBirth = new DateOnly(2023, 1, 15),
    ///             BiologicalSex = Sex.Female,
    ///             Address = new Address
    ///             {
    ///                 Use = AddressUse.Home,
    ///                 Line = new List&lt;string&gt;() { "string" },
    ///                 City = "string",
    ///                 State = "string",
    ///                 PostalCode = "string",
    ///                 Country = "string",
    ///                 Period = new Period(),
    ///             },
    ///         },
    ///         Relationship = Relationship.Self,
    ///         Patient = "string",
    ///         InsurancePlan = new InsurancePlan
    ///         {
    ///             MemberId = "string",
    ///             PayerId = "string",
    ///             PayerName = "string",
    ///             AdditionalPayerInformation = new AdditionalPayerInformation
    ///             {
    ///                 AvailityEligibilityId = "string",
    ///                 AvailityPayerId = "string",
    ///                 AvailityPayerName = "string",
    ///                 AvailityRemittancePayerId = "string",
    ///             },
    ///             GroupNumber = "string",
    ///             Name = "string",
    ///             PlanType = Candid.Net.PreEncounter.Coverages.V1.NetworkType.SelfPay,
    ///             Type = Candid.Net.PreEncounter.Coverages.V1.InsuranceTypeCode.C01,
    ///             Period = new Period(),
    ///             InsuranceCardImageLocator = "string",
    ///         },
    ///         Verified = true,
    ///         EligibilityChecks = new List&lt;EligibilityCheckMetadata&gt;()
    ///         {
    ///             new EligibilityCheckMetadata
    ///             {
    ///                 CheckId = "string",
    ///                 ServiceCode = ServiceTypeCode.MedicalCare,
    ///                 Status = EligibilityCheckStatus.Completed,
    ///                 InitiatedBy = "string",
    ///                 InitiatedAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///             },
    ///         },
    ///         LatestEligibilityCheck = new LatestEligibilityCheck
    ///         {
    ///             CheckId = "string",
    ///             Status = EligibilityStatus.Active,
    ///             InitiatedAt = new DateTime(2024, 01, 15, 09, 30, 00, 000),
    ///         },
    ///         Benefits = new CoverageBenefits(),
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
    /// Gets a coverage along with it's full history. The return list is ordered by version ascending.
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
    /// await client.PreEncounter.Coverages.V1.GetMultiAsync(
    ///     new CoverageGetMultiRequest { PatientId = "string" }
    /// );
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
    /// Scans up to 100 coverage updates. The since query parameter is inclusive, and the result list is ordered by updatedAt ascending.
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
    ///         Npi = "string",
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
    ///     "string"
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
